using Newtonsoft.Json;
using SF_Client.DiscordRPC;
using SF_Client.DiscordRPC.APIDatas;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace SF_Client
{
    class Tools
    {
        [DllImport("KERNEL32.DLL", EntryPoint = "SetProcessWorkingSetSize", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetProcessWorkingSetSize(IntPtr pProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

        [DllImport("KERNEL32.DLL", EntryPoint = "GetCurrentProcess", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetCurrentProcess();

        public static void SetProcessWorkingSize()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(GetCurrentProcess(), -1, -1);
            }
        }

        public static void LoadRPCImages()
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Deathbull\SF-Client\Avatars\"))
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Deathbull\SF-Client\Avatars\");
            using (HttpClient _ = new HttpClient())
            {
                _.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = _.GetAsync("https://discord.com/api/v6/oauth2/applications/738137354589437972/assets").Result;
                message.EnsureSuccessStatusCode();
                string ResponseBody = message.Content.ReadAsStringAsync().Result;

                Root DeserializedData = JsonConvert.DeserializeObject<Root>(ResponseBody.Replace("[", "{ Main : [").Replace("]", "]}"));

                for (int i = 0; i < DeserializedData.Main.Count; i++)
                {
                    string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Deathbull\SF-Client\Avatars\" + DeserializedData.Main[i].id + ".png";
                    if (File.Exists(FilePath))
                    {
                        Images.ImageList.Add(DeserializedData.Main[i].name, (Bitmap)Image.FromFile(FilePath));
                    }
                    else
                    {
                        using (WebClient webClient = new WebClient())
                        {
                            byte[] data = webClient.DownloadData($"https://cdn.discordapp.com/app-assets/738137354589437972/{DeserializedData.Main[i].id}.png");
                            using (MemoryStream ms = new MemoryStream(data))
                            {
                                Images.ImageList.Add(DeserializedData.Main[i].name, (Bitmap)Image.FromStream(ms));
                                new Bitmap(Image.FromStream(ms)).Save(FilePath, ImageFormat.Png);
                            }
                        }
                    }
                }
            }
        }

        public enum Quality : int
        {
            low = 0,
            medium = 1,
            high = 2,
            best = 3
        }
    }
}
