using ShellProgressBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;

namespace ytDownload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var d = new Download();

            var Users = new List<string>
            {
"UCHF0q5bAnwjyaHjgS2LrQJQ",
"UCivA7_KLKWo43tFcCkFvydw",
//"UC6zRX93ltP_qbucqLPiCLCQ",
"UCzOc0EEdwWAlnwrWV-7sDbg",
"UC9ecQ72p226Rbsm-leyxE8A",
"UCtM5z2gkrGRuWd0JQMx76qA",
"UCk6Gbz4FjgRgb732Qc4YCAg",
"UC7vVhkEfw4nOGp8TyDk7RcQ",
"UCt_t6FwNsqr3WWoL6dFqG9w",
"UCiefLm_nIz_gOH7XHbgpdCQ",
"UCLKFj0lOHWcbjx8Nrpcw_fg",
"UCEOXxzW2vU0P-0THehuIIeg",
"UC9z7EZAbkphEMg0SP7rw44A",
"UC2C_jShtL725hvbm1arSV9w",
"UCI9dGhdza3qupiV0mVNO97A",
"UCEas6ztXcwEkbaClw4zof9g",
"UCfznQ0w5WrO2unkohgNG1cQ",
"UCp68_FLety0O-n9QU6phsgw",
"UCs-SOeljpyBAvS6fYAR2egw",
"UCFGt_87bzlJXHxzvsU8leOQ",
"UCsn6cjffsvyOZCZxvGoJxGg",
"UChhoLhZzFvSKLW5eetPkxfQ",
"UCpXBGqwsBkpvcYjsJBQ7LEQ",
"UCMqzQ6ZsywIFHlt1Pg2ll8g",
"UCdC0An4ZPNr_YiFiYoVbwaw",
"UC0rDDvHM7u_7aWgAojSXl1Q",
"UCBvc7pmUp9wiZIFOXEp1sCg",
"UCM42XWqRoruK6bNkgbgoJMw",
"UCTGfnW-qn4P17TkWVq1BHSQ",
"UC-to_wlckb-bFDtQfUZL3Kw",
"UCioMCgNwL0_K0XZR6_2kgrg",
"UCJ0-OtVpF0wOKEqT2Z1HEtA",
"UC2bkHVIDjXS7sgrgjFtzOXQ",
"UCCOMbPkjAUjCDUEvuX1lLzQ",
"UCf11RYXIBsdJcJj8u5mKrCg",
"UCEPTp5WMAzjh9mOrKUwRLmQ",
"UCTRMnrbYTfBA2dgaQNavglg",
"UCnv0gfLQFNGPJ5MHSGuIAkw",
"UC6iWKC08iw9K-R6Wh5pbZNQ",
"UCG2_0hLUfH08zqXRVTjmWkQ",
"UCjtjQeFZVJY0MDqhQQATR0A",
"UCI4I6ldZ0jWe7vXpUVeVcpg",
"UCHCph-_jLba_9atyCZJPLQQ",
"UCELt4nocnWDEnYJmov4zqyA",
"UCBegkHWbzOTqwJ5lEqQ3WDw",
"UCHw6-Tni_p2-ExJH6XcN2Rw",
"UCuWAgvyiWcBeZ8sT0sJZyBg",
"UCDyCK-HRoSqUsowdKzOVHZA",
"UC4rK049V0A0xVUgXewVIYTQ",
"UCjo1uN-aM3rmBV46xj7l2KA",
"UC8WSl9lgw8Au68U86DcCw2w",
"UC6I6cZyUu_k2m8bWWmKiXWw",
"UCKAGuMf7fHFvOlOTIiyp-FA",
"UCdN4aXTrHAtfgbVG9HjBmxQ",
"UCsXVk37bltHxD1rDPwtNM8Q",
"UCJm5yR1KFcysl_0I3x-iReg",
"UCqZQJ4600a9wIfMPbYc60OQ",
"UCpJmBQ8iNHXeQ7jQWDyGe3A",
"UCNCSc6rLvgM1sh180q3tz_g",
"UC_c1gdsojLxBGkgzS0NsvUw",
"UCC1ZY1oz9CY6HitMJo1KV_w",
"UC3r7Ft0AvElrDtRuay6CNWg",
"UCY1kMZp36IQSyNx_9h4mpCg",
"UCFe-pfe0a9bDvWy74Jd7vFg",
"UCckETVOT59aYw80B36aP9vw",
"UCtHaxi4GTYDpJgMSGy7AeSw",
"UCV2V8LmuXKwWfVFW4RO3cQQ",
"UCIRiWCPZoUyZDbydIqitHtQ",
"UCUHW94eEFW7hkUMVaZz4eDg",
"UCvDstb1N4jSWKyeTDh0kTVw",
"UCwx8uy7nxohWLwnaPocLsyg",
"UC3YYjmYwjB6xuZBRNzmoIww",
"UCexp541IogQtMAT6SkKu-Tg",
"UCJlSdoi8YW8hUUfCQJZ-Ycw",
"UCAN9EtZF6VbQDUUz6OiUxqA",
"UCIgKGGJkt1MrNmhq3vRibYA",
"UCh9WpSqakALU6B1DQzR1_nA",
"UC3WTLNvjfzpo-cdk6LgbVTg",
"UCo0Ek8Te0osbhI0WnhF3QzA",
"UCt0p6hzGpnnMnSWrM9k8l_Q",
"UCMOqf8ab-42UUQIdVoKwjlQ",
"UCir93b_ftqInEaDpsWYbo_g",
"UCZWlSUNDvCCS1hBiXV0zKcA",
"UCAL3JXZSzSm8AlZyD3nQdBA",
"UC6MFZAOHXlKK1FI7V0XQVeA",
"UCmv1CLT6ZcFdTJMHxaR9XeA",
"UCs_qLltqO06cR6Rxz9szAqw",
"UCz_cDc_2arKIb6SlJoqFT0w",
"UC8R6ugX4nYk3G0KY4eTbblQ",
"UCpO92FrqHK958VPLhyajzug",
"UCDsO-0Yo5zpJk575nKXgMVA",
"UCvJiYiBUbw4tmpRSZT2r1Hw",
"UCkxMlA7rt-mnIc1AjbyAsPw",
"UCFESuLHQCq5Ir404brufUZQ",
"UCiry6CTLSfmRuNGmOtGFO-w",
"UCDom90xOqP4avehFjSJO6NA",
"UCWzSpTI0tK8wHjw4jmtDA_A",
"UCYbh0dBxuClavE6lVaGnQ_w",
"UC6107grRI4m0o2-emgoDnAA",
"UCpFuaxD-0PKLolFR3gWhrMw",
"UCIveFvW-ARp_B_RckhweNJw",
"UC-x4iL-dib6tLIfSD4orfQw",
"UC3sznuotAs2ohg_U__Jzj_Q",
"UCo_IB5145EVNcf8hw1Kku7w",
"UC1zZE_kJ8rQHgLTVfobLi_g",
"UC2Kw1SnSYxJFPlmECarRnWA",
"UCUK0HBIBWgM2c4vsPhkYY4w",
"UCf0Ppq1DSjA1eOvPbB68G5w",
"UCkuQUEBDhOJnZRzZmDb47fw",
"UC06E4Y_-ybJgBUMtXx8uNNw",
"UCmb8hO2ilV9vRa8cilis88A",
"UCHsRtomD4twRf5WVHHk-cMw",
"UCcaM7Q6-svmtbZUvkSL4G3w",
"UCASjdyu0y8XQ9qJnqxsKHnQ",
"UCN8JJf0CMRkZ6ozapl6nMCw",
"UCHnyfMqiRRG1u-2MsSQLbXA",
"UCchBatdUMZoMfJ3rIzgV84g",
"UCLXo7UDZvByw2ixzpQCufnA",
"UCiMlbeQWYRpajZhtRZH8UfQ",
"UC6nSFpj9HTCZ5t-N3Rm3-HA",
"UCywu6W9dKodKOv7Cb34URqQ",
"UCa1DgvQUuQnJmMCwlxZ7SSg",
"UCqYPhGiB9tkShZorfgcL2lA",
"UClqOm7dXSLwBP3iKvE8VtCg",
"UCGFhIp3VXy90--3PfAqtSaA",
"UCUC9UEfbjR-WtwaLV7q0xhQ"
            };
            foreach (var user in Users)
            {
                d.DownloadChannel(user).Wait();
            }
        }
    }

    public class Download
    {
        YoutubeClient client = new YoutubeClient();

        async public Task DownloadChannel(string channelId)
        {
            try
            {
                var channelInfo = await client.GetChannelAsync(channelId);
                Console.WriteLine(channelInfo.Title);
                var channelUploads = await client.GetChannelUploadsAsync(channelId);
                var folder = $@"F:\Videos\Youtube\{channelInfo.Title} [{channelId}]";
                System.IO.Directory.CreateDirectory(folder);
                var downloadedVideos = System.IO.Directory.EnumerateFiles(folder)
                    .Select(n => n.Split(".")
                        .Reverse()
                        .ToList()[1]
                        .Trim('[')
                        .Trim(']')
                        )
                    .ToList();
                foreach (var video in channelUploads)
                {
                    if (downloadedVideos.Contains(video.Id))
                    {
                        continue;
                    }

                    await DownloadVideo(video.Id, folder);
                }
            }
            catch
            {

            }

        }

        //async public Task DownloadPlaylist(string playListId)
        //{
        //    var playlist = await client.GetPlaylistAsync(playListId);
        //    foreach (var video in playlist.Videos)
        //    {
        //        await DownloadVideo(video.Id, $@"F:\Videos\Youtube\{channelInfo.Title}");
        //    }
        //}

        async public Task DownloadVideo(string videoId, string folder)
        {
            try
            {
                var video = await client.GetVideoAsync(videoId);

                var title = video.Title.CleanFileName();
                var author = video.Author.CleanFileName();
                var duration = video.Duration;
                var date = video.UploadDate;

                // Get metadata for all streams in this video
                var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(videoId);

                // ...or highest quality & highest framerate MP4 video stream
                var streamInfo = streamInfoSet.Muxed.WithHighestVideoQuality();

                // Get file extension based on stream's container   
                var ext = streamInfo.Container.GetFileExtension();

                var videoName = $"{folder}\\{author}-{date.ToString("yyyyMMddHH")}-{title}.[{video.Id}].{ext}";
                // Download stream to file
                var progress = new MyProgress(videoName);
                await client.DownloadMediaStreamAsync(streamInfo, videoName, progress);
                progress.Dispose();
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
            //client.DownloadMediaStreamAsync()
        }

    }
    public static class Extensions
    {
        public static string CleanFileName(this string name)
        {
            string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
            string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

            return System.Text.RegularExpressions.Regex.Replace(name, invalidRegStr, string.Empty);
        }
    }

    public class MyProgress : IProgress<double>, IDisposable
    {
        ProgressBar _bar;
        public MyProgress(string fileName)
        {
            const int totalTicks = 10000;
            var options = new ProgressBarOptions
            {
                ProgressCharacter = '─',
                ProgressBarOnBottom = true,
                BackgroundCharacter = '─',
                BackgroundColor = ConsoleColor.DarkGray,
                ForegroundColor = ConsoleColor.Green
            };
            _bar = new ProgressBar(totalTicks, fileName, options);
        }

        public void Dispose()
        {
            _bar.Dispose();
        }

        public void Report(double value)
        {

            while (_bar.CurrentTick / (double)_bar.MaxTicks < value)
            {
                _bar.Tick();
            }
        }
    }
}
