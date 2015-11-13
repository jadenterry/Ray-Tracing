using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ray_Tracing
{
    public partial class Form1 : Form
    {
        public static List<SceneObject> objects;
        public const float infinity = 9999999999999999f;
        public static List<Light> lights;
        public P3 camera = new P3 (0, -5, 0);
        public Sphere sphere = new Sphere(new P3(0, 0, 0), 1); 
        public const int size = 200;
        public RColor[,] pixels = new RColor[size, size];
        public RColor ambient = new RColor(.2f, .2f, .2f);
        public RColor directional = new RColor(2f, 0, 0);
        public P3 direction = P3.fromSpherical(3.5f, 3.1f);

        public Form1()
        {
            InitializeComponent();
            objects = new List<SceneObject> {
    new SceneObject(new Sphere(new P3(0,0,0), 1),
                    new SolidTexture(new RColor(1,1,1)),
                    new NonReflective())};
            lights = new List<Light> {
    new Ambient(new RColor(0.2f, 0.2f, 0.2f)),
    new Directional(new RColor(2,0,0), new P3(.4f,  -.5f, .2f).normalize())};
            noName();
        }

        //public static SceneObject shootRay(Ray r, out double d)
        //{
        //    float dist;
        //    SceneObject obj = closest(r);

        //    if (obj == null)
        //    {
        //        return null;
        //    }
        //    dist = obj.distance(r);
        //    if (dist == infinity)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return obj;
        //    }
        //}

        //public static SceneObject closest(Ray ray)
        //{
        //    SceneObject sceneObj = null;
        //    float dist, smallestDist = infinity;
            
        //    foreach (SceneObject obj in objects)
        //    {
        //        if ((dist = obj.distance(ray)) <= smallestDist)
        //        {
        //            smallestDist = dist;
        //            sceneObj = obj;
        //        }
        //    }
        //    return sceneObj;

        //}

        public void noName()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    float size1 = size;
                    P3 p = new P3(i / size1 * 2.0f - 1, 0, j / size1 * 2.0f - 1);
                    Ray r = new Ray(camera, p.sub(camera).normalize());
                    float distance = sphere.intersect(r);
                    if (distance != -1)
                    {
                        P3 sp = r.travel(distance);
                        P3 n = sphere.normal(sp);
                        float intensity = n.dotProduct(direction);
                        if (intensity < 0)
                        {
                            intensity = 0;
                        }

                        pixels[i, j] = directional.scalarMultiply(intensity);
                    
                    }
                    else
                    {
                        pixels[i, j] = new RColor(0, 0, 0);
                    }

                }
            }
            panel.Refresh();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    SolidBrush b = new SolidBrush(pixels[i, j].convert());
                    e.Graphics.FillRectangle(b, i, j, 1, 1);
                }
            }
        }

        private void headingBar_Scroll(object sender, ScrollEventArgs e)
        {
            direction = P3.fromSpherical(headingBar.Value, 3.1f);
            noName();
        }

        private void pitchBar_Scroll(object sender, ScrollEventArgs e)
        {
            direction = P3.fromSpherical(3.5f, pitchBar.Value);
            noName();
        }

        private void zoomBar_Scroll(object sender, ScrollEventArgs e)
        {
            camera = new P3(0, zoomBar.Value, 0);
            noName();
        }
        }
    }

