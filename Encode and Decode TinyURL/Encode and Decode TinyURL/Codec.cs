using System;
using System.Collections.Generic;
using System.Text;

namespace Encode_and_Decode_TinyURL
{
    /// <summary>
    /// TinyURL is a URL shortening service where you enter a URL such as https://leetcode.com/problems/design-tinyurl and it returns a short URL such as http://tinyurl.com/4e9iAk.
    /// Design the encode and decode methods for the TinyURL service.There is no restriction on how your encode/decode algorithm should work.You just need to ensure that a URL can be encoded to a tiny URL and the tiny URL can be decoded to the original URL.
    /// </summary>
    public class Codec
    {
        private Dictionary<string, string> dict = new Dictionary<string, string>();
        private string baseUrl = "http://tinyurl.com/";

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            string key = Guid.NewGuid().ToString();
            dict.Add(key, longUrl);
            return $"{baseUrl}{key}";
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            return dict.TryGetValue(shortUrl.Replace(baseUrl, ""), out string longUrl) ? longUrl : string.Empty;
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec codec = new Codec();
    // codec.decode(codec.encode(url));
}
