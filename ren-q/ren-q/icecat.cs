using System;
using System.Net;

namespace ren_q.icecat
{
    class Icecat
    {
        public static Byte[] DownloadIcecatFile()
        {
            string strDownloadURL = "http://data.Icecat.biz/export/freexml/EN/480237.xml";
            string strUser = "Your Login to Icecat Repository";
            string strPWD = "Your Password to Icecat Repository";



            // Creating an instance of a WebClient
            WebClient req = new WebClient();
            // Creating an instance of a credential cache,
            // and passing the username and password to it
            CredentialCache cache = new CredentialCache
            {
                { new Uri(strDownloadURL), "Basic", new NetworkCredential(strUser, strPWD) }
            };
            req.Credentials = cache;
            Byte[] fileData = req.DownloadData(strDownloadURL);
            return fileData;
        }

    }

}