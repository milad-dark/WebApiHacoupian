using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.IO;

namespace WebApiHacoupian.Extention
{
    public class JsonFileCreator
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public JsonFileCreator(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public bool InsertJson(string number)
        {
            string JSONresult = JsonConvert.SerializeObject(number);
            string path = _webHostEnvironment.ContentRootPath + "\\logs\\invoiceNumber.txt";

            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, number);
                //open file stream
                //using (StreamWriter file = File.CreateText(path))
                //{
                //    file.WriteLine(number);
                //    //JsonSerializer serializer = new JsonSerializer();
                //    //serializer.Serialize(file, JSONresult);
                //}
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetJson(string number)
        {
            string path = _webHostEnvironment.ContentRootPath + "\\logs\\invoiceNumber.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string lastNumber = "0";
                    lastNumber = sr.ReadLine();
                    sr.Close();
                    if (Convert.ToInt32(lastNumber) == Convert.ToInt32(number))
                    {
                        using (StreamWriter file = File.CreateText(path))
                        {
                            file.WriteLine((Convert.ToInt32(number) + 1).ToString());
                        }
                    }
                    return Convert.ToInt32(lastNumber);
                }
            }
            catch (Exception)
            {
                return 0;
            }
            
        }
    }
}
