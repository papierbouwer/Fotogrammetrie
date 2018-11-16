using System;
using System.IO;
using System.Text;
using fotogrammetrie;

namespace fotogrammetrieProgramma
{
    class Filesystem
    {
        private string filename;

        public Filesystem(string filename)
        {
            this.filename = filename;
        }

        public void WriteFile(FotogrammetrieData data)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(data.camera1.coordinaat.x + Environment.NewLine);
            builder.Append(data.camera1.coordinaat.y + Environment.NewLine);
            builder.Append(data.camera1.zichthoek + Environment.NewLine);
            builder.Append(data.camera1.resolutie + Environment.NewLine);

            builder.Append(data.camera2.coordinaat.x + Environment.NewLine);
            builder.Append(data.camera2.coordinaat.y + Environment.NewLine);
            builder.Append(data.camera2.zichthoek + Environment.NewLine);
            builder.Append(data.camera2.resolutie + Environment.NewLine);

            builder.Append(data.coordinaat1 + Environment.NewLine);
            builder.Append(data.coordinaat2 + Environment.NewLine);

            StreamWriter file = new StreamWriter(filename);
            file.WriteLine(builder.ToString());

            file.Close();
        }

        public FotogrammetrieData ReadFile()
        {
            FotogrammetrieData returnData = new FotogrammetrieData();
            //TODO: Add reading a file.
            try
            {
                string[] lines = File.ReadAllLines(filename);
                returnData.camera1 = new Camera
                (
                    Convert.ToInt32(lines[0]), 
                    Convert.ToInt32(lines[1]), 
                    Convert.ToDouble(lines[2]), 
                    Convert.ToInt16(lines[3])
                );
                returnData.camera2 = new Camera
                (
                    Convert.ToInt32(lines[4]),
                    Convert.ToInt32(lines[5]),
                    Convert.ToDouble(lines[6]),
                    Convert.ToInt16(lines[7])
                );
                returnData.coordinaat1 = Convert.ToInt32(lines[8]);
                returnData.coordinaat2 = Convert.ToInt32(lines[9]);
            }
            catch (Exception exception)
            {

                Console.WriteLine("An error was thrown: " + exception.ToString());
            }

            return returnData;
        }
    }
}
