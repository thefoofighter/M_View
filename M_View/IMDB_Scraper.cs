﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Net;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

/*******************************************************************************
 * Free ASP.net IMDb Scraper API for the new IMDb Template.
 * Author: Abhinay Rathore
 * Website: http://www.AbhinayRathore.com
 * Blog: http://web3o.blogspot.com
 * More Info: http://web3o.blogspot.com/2010/11/aspnetc-imdb-scraping-api.html
 * Last Updated: Sept 24, 2011
 *******************************************************************************/

namespace M_View
{
    public class IMDb
    {
        public bool status { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string Year { get; set; }
        public string Rating { get; set; }
        public ArrayList Genres { get; set; }
        public ArrayList Directors { get; set; }
        public ArrayList Writers { get; set; }
        public ArrayList Stars { get; set; }
        public ArrayList Cast { get; set; }
        public string MpaaRating { get; set; }
        public string ReleaseDate { get; set; }
        public string Plot { get; set; }
        public string Poster { get; set; }
        public string PosterLarge { get; set; }
        public string PosterSmall { get; set; }
        public string PosterFull { get; set; }
        public string Runtime { get; set; }
        public string Top250 { get; set; }
        public string Oscars { get; set; }
        public string Awards { get; set; }
        public string Nominations { get; set; }
        public string Storyline { get; set; }
        public string Tagline { get; set; }
        public string Votes { get; set; }
        public ArrayList Languages { get; set; }
        public ArrayList Countries { get; set; }
        public ArrayList ReleaseDates { get; set; }
        public ArrayList MediaImages { get; set; }
        public string ImdbURL { get; set; }

        //Search Engine URLs
        private string GoogleSearch = "http://www.google.com/search?q=imdb+";
        private string BingSearch = "http://www.bing.com/search?q=imdb+";
        private string AskSearch = "http://www.ask.com/web?q=imdb+";


        //Constructor
        public IMDb(string MovieName, bool GetExtraInfo = true)
        {
            string imdbUrl = getIMDbUrl(System.Uri.EscapeUriString(MovieName));
            status = false;
            if (!string.IsNullOrEmpty(imdbUrl))
            {
                string html = getUrlData(imdbUrl);
                parseIMDbPage(html, GetExtraInfo);
            }
        }

        //Get IMDb URL from search results
        private string getIMDbUrl(string MovieName, string searchEngine = "google")
        {
            string url = GoogleSearch + MovieName; //default to Google search
            if (searchEngine.ToLower().Equals("bing")) url = BingSearch + MovieName;
            if (searchEngine.ToLower().Equals("ask")) url = AskSearch + MovieName;
            string html = getUrlData(url);
            ArrayList imdbUrls = matchAll(@"<a href=""(http://www.imdb.com/title/tt\d{7}/)"".*?>.*?</a>", html);
            if (imdbUrls.Count > 0)
                return (string)imdbUrls[0]; //return first IMDb result
            else if (searchEngine.ToLower().Equals("google")) //if Google search fails
                return getIMDbUrl(MovieName, "bing"); //search using Bing
            else if (searchEngine.ToLower().Equals("bing")) //if Bing search fails
                return getIMDbUrl(MovieName, "ask"); //search using Ask
            else //search fails
                return string.Empty;
        }

        //Parse IMDb page data
        private void parseIMDbPage(string html, bool GetExtraInfo)
        {
            Id = match(@"<link rel=""canonical"" href=""http://www.imdb.com/title/(tt\d{7})/"" />", html);
            if (!string.IsNullOrEmpty(Id))
            {
                status = true;
                Title = match(@"<title>(IMDb \- )*(.*?) \(.*?</title>", html, 2);
                OriginalTitle = match(@"title-extra"">(.*?)<", html);
                Year = match(@"<title>.*?\(.*?(\d{4}).*?\).*?</title>", html);
                Rating = match(@"ratingValue"">(\d.\d)<", html);
                Genres = new ArrayList();
                Genres = matchAll(@"<a.*?>(.*?)</a>", match(@"Genres:</h4>(.*?)</div>", html));
                Directors = new ArrayList();
                Directors = matchAll(@"<a.*?>(.*?)</a>", match(@"Directors?:[\n\r\s]*</h4>(.*?)(</div>|>.?and )", html));
                Writers = matchAll(@"<a.*?>(.*?)</a>", match(@"Writers?:[\n\r\s]*</h4>(.*?)(</div>|>.?and )", html));
                Stars = matchAll(@"<a.*?>(.*?)</a>", match(@"Stars?:(.*?)</div>", html));
                Cast = matchAll(@"class=""name"">[\n\r\s]*<a.*?>(.*?)</a>", html);
                Plot = match(@"<p itemprop=""description"">(.*?)</p>", html);
                ReleaseDate = match(@"Release Date:</h4>.*?(\d{1,2} (January|February|March|April|May|June|July|August|September|October|November|December) (19|20)\d{2}).*(\(|<span)", html);
                Runtime = match(@"Runtime:</h4>[\s]*.*?(\d{1,4}) min[\s]*.*?\<\/div\>", html);
                if (String.IsNullOrEmpty(Runtime)) Runtime = match(@"infobar.*?([0-9]+) min.*?</div>", html);
                Top250 = match(@"Top 250 #(\d{1,3})<", html);
                Oscars = match(@"Won (\d{1,2}) Oscars\.", html);
                Awards = match(@"(\d{1,4}) wins", html);
                Nominations = match(@"(\d{1,4}) nominations", html);
                Storyline = match(@"Storyline</h2>[\s]*<p>(.*?)[\s]*(<em|</p>)", html);
                Tagline = match(@"Taglines?:</h4>(.*?)(<span|</div)", html);
                MpaaRating = match(@"infobar"">.*?<img.*?alt=""(.*?)"" src="".*?certificates.*?"".*?>", html);
                Votes = match(@"ratingCount"">(\d+,?\d*)</span>", html);
                Languages = new ArrayList();
                Languages = matchAll(@"<a.*?>(.*?)</a>", match(@"Language.?:(.*?)(</div>|>.?and )", html));
                Countries = new ArrayList();
                Countries = matchAll(@"<a.*?>(.*?)</a>", match(@"Country:(.*?)(</div>|>.?and )", html));
                Poster = match(@"img_primary"">[\n\r\s]*?<a.*?><img src=""(.*?)"".*?</td>", html);
                if (!string.IsNullOrEmpty(Poster) && Poster.IndexOf("nopicture") < 0)
                {
                    PosterSmall = Regex.Replace(Poster, @"_V1\..*?.jpg", "_V1._SY150.jpg");
                    PosterLarge = Regex.Replace(Poster, @"_V1\..*?.jpg", "_V1._SY500.jpg");
                    PosterFull = Regex.Replace(Poster, @"_V1\..*?.jpg", "_V1._SY0.jpg");
                }
                else
                {
                    Poster = string.Empty;
                    PosterSmall = string.Empty;
                    PosterLarge = string.Empty;
                    PosterFull = string.Empty;
                }
                ImdbURL = "http://www.imdb.com/title/" + Id + "/";
                if (GetExtraInfo)
                {
                    ReleaseDates = getReleaseDates();
                    MediaImages = getMediaImages();
                }
            }

        }

        //Get all release dates
        private ArrayList getReleaseDates()
        {
            ArrayList list = new ArrayList();
            string releasehtml = getUrlData("http://www.imdb.com/title/" + Id + "/releaseinfo");
            foreach (string r in matchAll(@"<tr>(.*?)</tr>", match(@"Date</th></tr>\n*?(.*?)</table>", releasehtml)))
            {
                Match rd = new Regex(@"<td>(.*?)</td>\n*?.*?<td align=""right"">(.*?)</td>", RegexOptions.Multiline).Match(r);
                list.Add(StripHTML(rd.Groups[1].Value.Trim()) + " = " + StripHTML(rd.Groups[2].Value.Trim()));
            }
            return list;
        }

        //Get all media images
        private ArrayList getMediaImages()
        {
            ArrayList list = new ArrayList();
            string mediaurl = "http://www.imdb.com/title/" + Id + "/mediaindex";
            string mediahtml = getUrlData(mediaurl);
            int pagecount = matchAll(@"<a href=""\?page=(.*?)"">", match(@"<span style=""padding: 0 1em;"">(.*?)</span>", mediahtml)).Count;
            for (int p = 1; p <= pagecount + 1; p++)
            {
                mediahtml = getUrlData(mediaurl + "?page=" + p);
                foreach (Match m in new Regex(@"src=""(.*?)""", RegexOptions.Multiline).Matches(match(@"<div class=""thumb_list"" style=""font-size: 0px;"">(.*?)</div>", mediahtml)))
                {
                    String image = m.Groups[1].Value;
                    list.Add(Regex.Replace(image, @"_V1\..*?.jpg", "_V1._SY0.jpg"));
                }
            }
            return list;
        }

        //Match single instance
        private string match(string regex, string html, int i = 1)
        {
            return new Regex(regex, RegexOptions.Multiline).Match(html).Groups[i].Value.Trim();
        }

        //Match all instances and return as ArrayList
        private ArrayList matchAll(string regex, string html, int i = 1)
        {
            ArrayList list = new ArrayList();
            foreach (Match m in new Regex(regex, RegexOptions.Multiline).Matches(html))
                list.Add(m.Groups[i].Value.Trim());
            return list;
        }

        //Strip HTML Tags
        static string StripHTML(string inputString)
        {
            return Regex.Replace(inputString, @"<.*?>", string.Empty);
        }

        //Get URL Data
        private string getUrlData(string url)
        {
            WebClient client = new WebClient();
            Random r = new Random();
            //Random IP Address
            client.Headers["X-Forwarded-For"] = r.Next(0, 255) + "." + r.Next(0, 255) + "." + r.Next(0, 255) + "." + r.Next(0, 255);
            //Random User-Agent
            client.Headers["User-Agent"] = "Mozilla/" + r.Next(3, 5) + ".0 (Windows NT " + r.Next(3, 5) + "." + r.Next(0, 2) + "; rv:2.0.1) Gecko/20100101 Firefox/" + r.Next(3, 5) + "." + r.Next(0, 5) + "." + r.Next(0, 5);
            StringBuilder sb = new StringBuilder();
            try
            {
                Stream datastream = client.OpenRead(url);
                StreamReader reader = new StreamReader(datastream);
                
                while (!reader.EndOfStream)
                    sb.Append(reader.ReadLine());
                
            }
            catch (Exception u)
            {
                MessageBox.Show("Couldn't load the Movie data!\nTry the Reload Button or make sure the folder name is an actual movie name!\n\nException Text : \n" + u.ToString(), "Image failed to load! Soz :(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return sb.ToString();
            
        }
    }
}