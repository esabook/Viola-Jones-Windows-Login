using System;
using System.Diagnostics;
using Emgu.CV.Structure;

namespace Emgu.CV
{
   [Serializable]
   public class EigenObjectRecognize
   {
	  public static int nilaiEigen = 500;
      public Image<Gray, Single>[] _eigenImages;
      public Image<Gray, Single> _avgImage;
      public Matrix<float>[] _eigenValues;
      public string[] _labels;
      public  double _eigenDistanceThreshold;
      public static string stateS = string.Empty;
      
      /// <summary>
      /// untuk akses vektor eigen dari eigen space
      /// </summary>
      public Image<Gray, Single>[] EigenImages
      {
         get { return _eigenImages; }
         set { _eigenImages = value; }
      }

      /// <summary>
      /// untuk pelabelan berdasarkan gambar yang disimpan
      /// </summary>
      public String[] Labels
      {
         get { return _labels; }
         set { _labels = value; }
      }

      /// <summary>
      /// untuk ambang batas --- jarak eigen
      /// semakinbesar nilai ini, semakin banyak untuk toleransi deteksi mukanya. 
      /// </summary>
      public double EigenDistanceThreshold
      {
         get { return _eigenDistanceThreshold; }
         set { _eigenDistanceThreshold = value; }
      }

      /// <summary>
      /// ambil rata" gambar
      /// </summary>
      /// <remarks>digunakan untuk deserialization</remarks>
      public Image<Gray, Single> AverageImage
      {
         get { return _avgImage; }
         set { _avgImage = value; }
      }

      /// <summary>
      /// ambil nilai eigen dari setiap gambar yg telah disimpan
      /// </summary>
      public Matrix<float>[] EigenValues
      {
         get { return _eigenValues; }
         set { _eigenValues = value; }
      }


      /// <summary>
      /// membuat deteksian berdasarkan data and parameter gambar yang disimpan, mengemmbalikan nilai gambar yang mirip/sesuai
      /// </summary>
      /// <param name="images">gambar yang di cocokka harus sesama ukuran.</param>
      /// <param name="termCrit">untuk gambar</param>
      public EigenObjectRecognize(Image<Gray, Byte>[] images, ref MCvTermCriteria termCrit)
         : this(images, GenerateLabels(images.Length), ref termCrit)
      {
      }

      private static String[] GenerateLabels(int size)
      {
         String[] labels = new string[size];
         for (int i = 0; i < size; i++)
            labels[i] = i.ToString();
         return labels;
      }

      public EigenObjectRecognize(Image<Gray, Byte>[] images, String[] labels, ref MCvTermCriteria termCrit)
         : this(images, labels, 0, ref termCrit)
      {
      }

      /// <param name="eigenDistanceThreshold">
      /// eigen distance threshold, (0, ~1000].
      /// </param>
      /// <param name="termCrit">The criteria for recognizer training</param>
      public EigenObjectRecognize(Image<Gray, Byte>[] images, String[] labels, double eigenDistanceThreshold, ref MCvTermCriteria termCrit)
      {
         Debug.Assert(images.Length == labels.Length, "=================================","Masalah!!!");
         Debug.Assert(eigenDistanceThreshold >= nilaiEigen, "===================================","Ambang harus diatas "+nilaiEigen);
         
          CalcEigenObjects(images, ref termCrit, out _eigenImages, out _avgImage);
         _eigenValues = Array.ConvertAll<Image<Gray, Byte>, Matrix<float>>(images,
             delegate(Image<Gray, Byte> img)
             {
                return new Matrix<float>(EigenDecomposite(img, _eigenImages, _avgImage));
             });

         _labels = labels;
         _eigenDistanceThreshold = eigenDistanceThreshold;
      }

      #region static methods
      /// <summary>
      /// menghitung eigen gambar dari gambar tertentu
      /// </summary>
      public static void CalcEigenObjects(Image<Gray, Byte>[] trainingImages, ref MCvTermCriteria termCrit, out Image<Gray, Single>[] eigenImages, out Image<Gray, Single> avg)
      {
          stateS = "Menghitung Eigen Gambar";
          
         int width = trainingImages[0].Width;
         int height = trainingImages[0].Height;

         IntPtr[] inObjs = Array.ConvertAll<Image<Gray, Byte>, IntPtr>(trainingImages, delegate(Image<Gray, Byte> img) { return img.Ptr; });

         if (termCrit.max_iter <= 0 || termCrit.max_iter > trainingImages.Length)
            termCrit.max_iter = trainingImages.Length;
         
         int maxEigenObjs = termCrit.max_iter;

         #region initialize eigen images
         eigenImages = new Image<Gray, float>[maxEigenObjs];
         for (int i = 0; i < eigenImages.Length; i++)
            eigenImages[i] = new Image<Gray, float>(width, height);
         IntPtr[] eigObjs = Array.ConvertAll<Image<Gray, Single>, IntPtr>(eigenImages, delegate(Image<Gray, Single> img) { return img.Ptr; });
         #endregion

         avg = new Image<Gray, Single>(width, height);

         CvInvoke.cvCalcEigenObjects(
             inObjs,
             ref termCrit,
             eigObjs,
             null,
             avg.Ptr);
         stateS = "Menghitung Eigen Gambar -- Selesai";
      }

      /// <summary>
      ///decompose gambar menjadi nilai eigen, menggunakan verktor eigen
      /// </summary>
      public static float[] EigenDecomposite(Image<Gray, Byte> src, Image<Gray, Single>[] eigenImages, Image<Gray, Single> avg)
      {
          stateS = "Menghitung Dekomposisi Eigen";
         return CvInvoke.cvEigenDecomposite(
             src.Ptr,
             Array.ConvertAll<Image<Gray, Single>, IntPtr>(eigenImages, delegate(Image<Gray, Single> img) { return img.Ptr; }),
             avg.Ptr);
      }
      #endregion

      /// <summary>
      /// rekonstruksi gambar berdasarkan nilaieigen
      /// </summary>
      public Image<Gray, Byte> EigenProjection(float[] eigenValue)
      {
          stateS = "Proyeksi Objek ke Sub-ruang Eigen";
         Image<Gray, Byte> res = new Image<Gray, byte>(_avgImage.Width, _avgImage.Height);
         CvInvoke.cvEigenProjection(
             Array.ConvertAll<Image<Gray, Single>, IntPtr>(_eigenImages, delegate(Image<Gray, Single> img) { return img.Ptr; }),
             eigenValue,
             _avgImage.Ptr,
             res.Ptr);
         return res;
      }

      /// <summary>
      ///ambil jarak-eigen Euclidean antara gambar yang akan dicocokkan dan semua gambar yang telah disimpan
      /// <returns>sebuah array jarak-eigen dari gambar yang disimpan</returns>
      public float[] GetEigenDistances(Image<Gray, Byte> image)
      {
          stateS = "Menghitung Jarak Eigen";
         using (Matrix<float> eigenValue = new Matrix<float>(EigenDecomposite(image, _eigenImages, _avgImage)))
            return Array.ConvertAll<Matrix<float>, float>(_eigenValues,
                delegate(Matrix<float> eigenValueI)
                {
                   return (float)CvInvoke.cvNorm(eigenValue.Ptr, eigenValueI.Ptr, Emgu.CV.CvEnum.NORM_TYPE.CV_L2, IntPtr.Zero);
                });
      }

      /// <summary>
      /// menerima gambar yang akan dicocokkan dari database, mencari yang cocok, dan return nilai indeks array dari jarak-eigen
      /// </summary>
      public void FindMostSimilarObject(Image<Gray, Byte> image, out int index, out float eigenDistance, out String label)
      {
          stateS = "Membandingkan dengan DataBase Wajah";
         float[] dist = GetEigenDistances(image);

         index = 0;
         eigenDistance = dist[0];
         for (int i = 1; i < dist.Length; i++)
         {
            if (dist[i] < eigenDistance)
            {
               index = i;
               eigenDistance = dist[i];
            }
         }
         label = Labels[index];
         stateS = "Membandingkan dengan DataBase Wajah -- selesai";
      }

      /// buat String.Empty, jika tidak mendeteksi;
      public String Recognize(Image<Gray, Byte> image)
      {
         stateS = "Mencoba Mengenali Wajah";
         int index;
         float eigenDistance;
         String label;
         FindMostSimilarObject(image, out index, out eigenDistance, out label);
         if ((_eigenDistanceThreshold <= 0 || eigenDistance < _eigenDistanceThreshold))
         {
             stateS = "Mencoba Mengenali Wajah -- selesai";
         }
         else { stateS = "Wajah Tidak Dikenali -- selesai"; }
         return (_eigenDistanceThreshold <= 0 || eigenDistance < _eigenDistanceThreshold )  ? _labels[index] : String.Empty;
      }
   }
}
