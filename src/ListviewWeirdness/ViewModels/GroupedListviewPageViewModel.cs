using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ListviewWeirdness.Models;
using Prism.Navigation;
using Xamarin.Forms.Internals;

namespace ListviewWeirdness.ViewModels
{
    public class GroupedListviewPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private ObservableCollection<MovieItemGroup> _movieGroups;
        public ObservableCollection<MovieItemGroup> MovieGroups
        {
            get { return _movieGroups; }
            set { SetProperty(ref _movieGroups, value); }
        }

        public GroupedListviewPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Movies";
            _navigationService = navigationService;
            GetData();
        }

        private void GetData()
        {
            MovieGroups = new ObservableCollection<MovieItemGroup>();
            var movies = new List<MovieItem>();
            movies.Add(new MovieItem { Id = 1, ReleaseDate = DateTime.Now, Title = "Gkjsdnnk", Overview = "53238fb8-62a4-4a5d-adbf-a73878275a6f", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 2, ReleaseDate = DateTime.Now, Title = "CalmTouch.com", Overview = "38b88eb4-42af-4e20-8cff-9fbc396d16a3", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 3, ReleaseDate = DateTime.Now, Title = "Multron", Overview = "fac7d8b5-9161-4a92-a938-463905905e85", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 4, ReleaseDate = DateTime.Now, Title = "Sand Flower", Overview = "53a6a9d1-380e-4096-a62f-3c0ddd98b875", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 5, ReleaseDate = DateTime.Now, Title = "Fluff and Stuff Animal Groomers", Overview = "2ecb3341-d142-41d5-ad22-873490f65168", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 6, ReleaseDate = DateTime.Now, Title = "KrillGreen", Overview = "50e83930-2578-4a50-83c3-9172b3afa7ec", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 7, ReleaseDate = DateTime.Now, Title = "Matrix Geoforms", Overview = "b48763d0-c85a-486e-9bd8-112f42129567", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 8, ReleaseDate = DateTime.Now, Title = "Acruex", Overview = "be429f30-5954-41cd-ac48-31e7c57d2ea8", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 9, ReleaseDate = DateTime.Now, Title = "iZinc", Overview = "adbf3f71-1ab4-4cce-9252-9fa2808752b1", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 10, ReleaseDate = DateTime.Now.AddDays(-1), Title = "Geekwagon", Overview = "8b07ad4f-c456-4a5b-b429-ef5795c53fae", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 11, ReleaseDate = DateTime.Now.AddDays(-1), Title = "Magmina", Overview = "befcbbc1-5da8-45ad-8194-ff7a42ee07b2", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 12, ReleaseDate = DateTime.Now.AddDays(-1), Title = "Career Cast", Overview = "a6a8d213-07a9-4f0d-b44c-bf647a3d93ac", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 13, ReleaseDate = DateTime.Now.AddDays(-1), Title = "MojoInvestor.com", Overview = "9a9bbec8-1971-4806-b5c2-80e1794d1dea", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 14, ReleaseDate = DateTime.Now.AddDays(-1), Title = "Web Muse", Overview = "a1ee77fc-817c-461c-a123-9f03dce17d1e", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 15, ReleaseDate = DateTime.Now, Title = "Isologix", Overview = "cb7ad472-ad13-4ff9-9204-19ac8bd4e437", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 16, ReleaseDate = DateTime.Now, Title = "Verbus", Overview = "8c27224a-4a83-41b9-a70b-40ab5d8a5606", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 17, ReleaseDate = DateTime.Now, Title = "Avenetro", Overview = "2280250a-19a7-47e7-88a1-b94a93f75bec", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 18, ReleaseDate = DateTime.Now, Title = "DyeRite", Overview = "4898bc5f-3763-426f-b609-35466029363b", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 19, ReleaseDate = DateTime.Now, Title = "Coriander", Overview = "89c06328-1b48-4e5b-8291-ab61aa40dd28", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 20, ReleaseDate = DateTime.Now.AddDays(-2), Title = "Newcube", Overview = "6d67d255-9e87-4bbd-a744-c57485f00ac7", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 21, ReleaseDate = DateTime.Now.AddDays(-2), Title = "High Life, Inc.", Overview = "7a3f021e-7267-4371-9806-ca38fc77f99f", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 22, ReleaseDate = DateTime.Now.AddDays(-2), Title = "LEAD – Leadership Education and Adult Direction", Overview = "6f160ffe-b786-4244-9e64-c19ae2dd3493", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 23, ReleaseDate = DateTime.Now.AddDays(-2), Title = "Comglomerate", Overview = "f814032e-d388-4de0-aeb1-1c2a937a3973", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });
            movies.Add(new MovieItem { Id = 24, ReleaseDate = DateTime.Now.AddDays(-2), Title = "Technology Wizard", Overview = "92680869-b010-4568-a649-d8aef0c42f13", Poster = "https://upload.wikimedia.org/wikipedia/commons/6/64/Poster_not_available.jpg" });

            var groups = movies.GroupBy(m => m.ReleaseDate);
            foreach (var group in groups)
            {
                var groupItem = new MovieItemGroup();
                groupItem.ReleaseDate = group.Key;

                foreach (var groupedItem in group)
                {
                    groupItem.Add(new MovieItem
                    {
                        Id = groupedItem.Id,
                        Title = groupedItem.Title,
                        Overview = groupedItem.Overview,
                        Poster = groupedItem.Poster
                    });
                }

                MovieGroups.Add(groupItem);
            }

        }
    }
}
