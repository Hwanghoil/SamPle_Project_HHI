using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballSample_HHI.Model
{
    public class Profile
    {
        public string Picture { get; set; }


        public List<Profile> GetProfile(int num)
        {
            var Face = new List<Profile>();

            switch (num)
            {
                case 1:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/a.png"
                    });
                    return Face;
                case 2:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/Yo.png"
                    });
                    return Face;
                case 3:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/S.png"
                    });
                    return Face;
                case 4:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/Jo.png"
                    });
                    return Face;
                case 5:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/CHW.png"
                    });
                    return Face;
                case 6:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/Ro.png"
                    });
                    return Face;
                case 7:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/Ro.png"
                    });
                    return Face;
                case 8:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/Sim.png"
                    });
                    return Face;
                case 9:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/S.png"
                    });
                    return Face;
                case 10:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/Ro.png"
                    });
                    return Face;
                case 11:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/S.png"
                    });
                    return Face;
                case 12:
                    Face.Add(new Profile
                    {
                        Picture = "/Image/Ro.png"
                    });
                    return Face;
            }
            return Face;
        }
    }
}
