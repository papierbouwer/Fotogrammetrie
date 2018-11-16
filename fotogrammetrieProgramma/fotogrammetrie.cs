using System;

namespace fotogrammetrie
{
    public class Camera
    {
        public Coordinaat coordinaat;
        public double zichthoek;
        public short resolutie;

        public Camera()
        {

        }

        public Camera(double x, double y, double zichthoek, short resolutie)
        {
            coordinaat.x = x;
            coordinaat.y = y;
            this.zichthoek = zichthoek;
            this.resolutie = resolutie;
        }

        public Camera(Coordinaat coordinaat, double zichthoek, short resolutie)
        {
            this.coordinaat.x = coordinaat.x;
            this.coordinaat.y = coordinaat.y;
            this.zichthoek = zichthoek;
            this.resolutie = resolutie;
        }

        public void Reset()
        {
            coordinaat.x = 0;
            coordinaat.y = 0;
            zichthoek = 0;
            resolutie = 0;
        }
    }

    public class Fotogrammetrie
    {
        private Camera camera1;
        private Camera camera2;
        private short coordinaat1;
        private short coordinaat2;

        public Fotogrammetrie()
        {
            camera1 = new Camera();
            camera2 = new Camera();
        }

        public Fotogrammetrie(Camera camera1, Camera camera2, short coordinaat1, short coordinaat2)
        {
            updateData(camera1, camera2, coordinaat1, coordinaat2);
        }

        public Fotogrammetrie(Coordinaat coordinaatCamera1, short zichthoekCamera1, short resolutieCamera1, Coordinaat coordinaatCamera2, short zichthoekCamera2, short resolutieCamera2, short coordinaat1, short coordinaat2)
        {
            camera1 = new Camera(coordinaatCamera1, zichthoekCamera1, resolutieCamera1);
            camera2 = new Camera(coordinaatCamera2, zichthoekCamera2, resolutieCamera2);

            this.coordinaat1 = coordinaat1;
            this.coordinaat2 = coordinaat2;
        }

        public Coordinaat berekenWaarde()
        {
            Coordinaat returnValue;
            returnValue.x = lineaireRayXberekening();
            returnValue.y = lineaireRayFunctie(returnValue.x, camera1, coordinaat1);
            return returnValue;
        }

        private static double lineaireRayFunctie(double x, Camera camera, short coordinaat)
        {
            double tanCamera = Math.Tan(camera.zichthoek / 2);
            double p = coordinaat - (camera.resolutie / 2);

            return ((p * tanCamera * (x - camera.coordinaat.x)) / (camera.resolutie / 2)) + camera.coordinaat.y;
        }

        private double lineaireRayXberekening()
        {
            double tanCamera1 = Math.Tan(camera1.zichthoek / 2);
            double tanCamera2 = Math.Tan(camera2.zichthoek / 2);

            double b1 = camera1.resolutie / 2;
            double b2 = camera2.resolutie / 2;

            double p1 = coordinaat1 - b1;
            double p2 = coordinaat2 - b2;

            double teller = b1 * b2 * (camera1.coordinaat.y - camera2.coordinaat.y) - camera1.coordinaat.x * b2 * p1 * tanCamera1 + camera2.coordinaat.x * b1 * p2 * tanCamera2;
            double noemer = b1 * p2 * tanCamera2 - b2 * p1 * tanCamera1;

            return teller / noemer;
        }

        public void updateData(FotogrammetrieData data)
        {
            camera1 = data.camera1;
            camera2 = data.camera2;

            coordinaat1 = Convert.ToInt16(data.coordinaat1);
            coordinaat2 = Convert.ToInt16(data.coordinaat2);
        }

        public void updateData(Camera camera1, Camera camera2, short coordinaat1, short coordinaat2)
        {
            this.camera1 = camera1;
            this.camera2 = camera2;
            this.coordinaat1 = coordinaat1;
            this.coordinaat2 = coordinaat2;
        }

        public void Reset()
        {
            camera1.Reset();
            camera2.Reset();

            coordinaat1 = 0;
            coordinaat2 = 0;
        }
    }

    public struct Coordinaat
    {
        public double x, y;
    }

    public struct FotogrammetrieData
    {
        public Camera camera1, camera2;

        public int coordinaat1, coordinaat2;
    }
}
