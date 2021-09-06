using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    internal class LookHowSomeoneChangeLogic
    {
        private readonly List<int> m_ChosenYears = new List<int>();
        private readonly List<Photo> r_FriendProfilePictures = new List<Photo>();
        private User m_ChosenUser;

        public List<Photo> FriendProfilePictures
        {
            get
            {
                return r_FriendProfilePictures;
            }
        }

        internal List<int> ChosenYears
        {
            get
            {
                return m_ChosenYears;
            }
        }

        internal User ChosenUser
        {
            get { return m_ChosenUser; }
            set { m_ChosenUser = value; }
        }

        private void FetchYears(List<int> i_ChoosesYearsByUser)
        {
            foreach (int year in i_ChoosesYearsByUser)
            {
                m_ChosenYears.Add(year);
            }
        }

        internal void FetchFriendTimeLinePictures(User i_ChosenUser, List<int> i_YearsChosen)
        {
            int i = 0;
            int sizeOfTheAlbum = 0;
            ChosenUser = i_ChosenUser;

            if (m_ChosenYears.Count != 0)
            {
                m_ChosenYears.Clear();
            }

            FetchYears(i_YearsChosen);
            if (FriendProfilePictures.Count != 0)
            {
                FriendProfilePictures.Clear();
            }

            foreach (Album album in ChosenUser.Albums)
            {
                Photo newPhotoToAdd = new Photo();

                if (album.Name == "Profile Pictures")
                {
                    sizeOfTheAlbum = (int)album.Photos.Count;

                    foreach (int year in ChosenYears)
                    {
                        i = 0;
                        while (i < sizeOfTheAlbum)
                        {
                            if (album.Photos[i].CreatedTime.Value.Year != year)
                            {
                                i++;
                            }
                            else
                            {
                                newPhotoToAdd = album.Photos[i];
                                FriendProfilePictures.Add(newPhotoToAdd);
                                break;
                            }
                        }
                    }

                    break;
                }
            }
        }
    }
}


