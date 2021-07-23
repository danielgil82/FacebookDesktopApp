using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAppLogic
{
    public class TimeLineInfo
    {
        private User m_ChosenUser;
        private readonly List<int> m_ChoosenYears = new List<int>();
        private readonly Dictionary<int, UserPhotoInfo> r_UserPhotosInfo = new Dictionary<int, UserPhotoInfo>();


        public List<int> ChosenYears
        {
            get
            {
                return m_ChoosenYears;
            }
        }

        public Dictionary<int, UserPhotoInfo> UserPhotosInfo
        {
            get
            {
                return r_UserPhotosInfo;
            }
        }

        public User ChosenUser
        {
            get
            {
                return m_ChosenUser;
            }
            set
            {
                m_ChosenUser = value;
            }
        }

        public TimeLineInfo()
        {

        }

        private void FetchYears(List<int> i_ChoosesYearsByUser)
        {
            foreach (int year in i_ChoosesYearsByUser)
            {
                m_ChoosenYears.Add(year);
            }

            m_ChoosenYears.Sort();
        }

        public class UserPhotoInfo
        {
            private Photo m_Photo;
            private string m_PhotoDescription;
            private FacebookObjectCollection<PhotoTag> m_PhotoTags = new FacebookObjectCollection<PhotoTag>();
            private string m_PhotosCreationDate = string.Empty;

            public string PhotosCreationDate
            {
                get
                {
                    return m_PhotosCreationDate;
                }
                set
                {
                    m_PhotosCreationDate = value;
                }
            }

            public Photo ChoosenPhoto
            {
                get
                {
                    return m_Photo;
                }
            }

            public FacebookObjectCollection<PhotoTag> PhotoTags
            {
                get
                {
                    return m_PhotoTags;
                }
                set
                {
                    m_PhotoTags = value;
                }
            }

            public string PhotoDescription
            {
                get
                {
                    return m_PhotoDescription;
                }
                private set
                {
                    m_PhotoDescription = value;
                }
            }

            public UserPhotoInfo(Photo i_ChoosenPhoto)
            {
                m_Photo = i_ChoosenPhoto;
                PhotoDescription = ChoosenPhoto.Name;
                PhotoTags = ChoosenPhoto.Tags;
                PhotosCreationDate = ChoosenPhoto.CreatedTime.ToString();
            }
        }

        internal void FetchTimeLinePhotos(User i_ChosenUser, List<int> i_YearsChosen)
        {
            int counter = ChosenYears.Count;
            ChosenUser = i_ChosenUser;
            Hashtable takenPhotos = new Hashtable();
            int i = 0;
            FetchYears(i_YearsChosen);

            if(takenPhotos.Count != 0)
            {
                takenPhotos.Clear();
            }

            if(UserPhotosInfo.Count != 0)
            {
                UserPhotosInfo.Clear();
            }

            foreach (int year in ChosenYears)
            {
                foreach (Album album in ChosenUser.Albums)
                {

                    if (album.CreatedTime.Value.Year == year && album.Photos.Count > 0)
                    {
                        
                        
                        if (!takenPhotos.Contains(album.Photos[i]))
                        {
                            takenPhotos.Add(album.Photos[i], year);
                            UserPhotosInfo.Add(year, new UserPhotoInfo(album.Photos[i]));
                            break;
                        }
                        else
                        {
                            while (i < album.Photos.Count && takenPhotos.Contains(album.Photos[i]))
                            {
                                i++;
                            }

                            if (i == album.Photos.Count)
                            {
                                throw new ArgumentException("Not enough photos in this year");
                            }

                            takenPhotos.Add(album.Photos[i], year);
                            UserPhotosInfo.Add(year, new UserPhotoInfo(album.Photos[i]));
                            break;
                        }
                    }
                }
            }
        }
    }
}
