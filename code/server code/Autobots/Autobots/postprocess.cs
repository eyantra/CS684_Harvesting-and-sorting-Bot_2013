using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using System.Drawing;

namespace Autobots
{
    class postprocess
    {
        public Image<Gray, byte> finalimage;
        Seq<Point> hull;
        MCvBox2D box;
        int sizethreshold;
        public List<tomato> sare_tamatr = new List<tomato>();
      
        public postprocess(ref Image<Gray, byte> image,int minsize)
        {
            finalimage = image.Copy();
            sizethreshold = minsize;
        }
        public void dilateErode(int dilate,int erode)
        {
           finalimage =finalimage.Erode(erode).Dilate(dilate);;
            
           
        }
        public Image<Gray, byte> getresult()
        {
            findobejct();
            return finalimage;
        
        }
        void findobejct()
        {

            using (MemStorage storage = new MemStorage())
            {              
                Contour<Point> contours = finalimage.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage);
                Contour<Point> biggestContour = null;

                
                while (contours != null)
                {
                                            
                       biggestContour = contours;
                       hull= biggestContour.GetConvexHull(Emgu.CV.CvEnum.ORIENTATION.CV_CLOCKWISE);
                     box=  hull.GetMinAreaRect();
                    tomato tamatr=new tomato();
                    tamatr.x=(int)box.center.X;
                    tamatr.y=(int)box.center.Y;
                    tamatr.h=(int)box.size.Height;
                    tamatr.w=(int)box.size.Width;
                    if (box.size.Height * box.size.Width > sizethreshold)
                    {
                        sare_tamatr.Add(tamatr);
                        finalimage.Draw(box.MinAreaRect(), new Gray(255), 2); 
                    }
                    contours = contours.HNext;
                    
                }
                
            }
        
        }
        
    }
}
