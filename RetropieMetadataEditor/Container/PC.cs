using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Drawing;
using System.Text;
using System.Globalization;

namespace RetropieMetadataEditor.Container
{
    public class PC : Rom
    {
        public PC(string romPath, Platform platform, RomType romType) : base(romPath, platform, romType)
        {
        }

        override public void LoadMetadata()
        {
            MetaXmlNode = Platform.XmlGamelist.DocumentElement.SelectSingleNode("game[path = \"./" + RomInfo.Name + "\"]");

            if (MetaXmlNode != null)
            {
                NoMetadata = false;
                MetaPath = GetXmlValue(MetaXmlNode.SelectSingleNode("path"));
                MetaName = GetXmlValue(MetaXmlNode.SelectSingleNode("name"));
                MetaDesc = GetXmlValue(MetaXmlNode.SelectSingleNode("desc"));
                MetaImage = GetXmlValue(MetaXmlNode.SelectSingleNode("image"));
                MetaRating = GetXmlValue(MetaXmlNode.SelectSingleNode("rating"));
                MetaReleasdate = GetXmlValue(MetaXmlNode.SelectSingleNode("releasedate"));
                MetaReleasdateDatetime = Library.ParseDatetime(MetaReleasdate);
                MetaDeveloper = GetXmlValue(MetaXmlNode.SelectSingleNode("developer"));
                MetaPublisher = GetXmlValue(MetaXmlNode.SelectSingleNode("publisher"));
                MetaGenre = GetXmlValue(MetaXmlNode.SelectSingleNode("genre"));
                MetaPlayers = GetXmlValue(MetaXmlNode.SelectSingleNode("players"));
                int players = 0;
                int.TryParse(MetaPlayers, out players);
                MetaPlayersInt = players;
                MetaPlaycount = GetXmlValue(MetaXmlNode.SelectSingleNode("playcount"));
                int playCount = 0;
                int.TryParse(MetaPlaycount, out playCount);
                MetaPlaycountInt = playCount;
                MetaLastplayed = GetXmlValue(MetaXmlNode.SelectSingleNode("lastplayed"));
                MetaLastplayedDatetime = Library.ParseDatetime(MetaLastplayed);

                if (MetaImage != string.Empty)
                {
                    NoImage = false;
                    ImageInfo = new FileInfo(MetaImage);
                    ImagePath = Path.Combine(Platform.PathImages, ImageInfo.Name);
                    ImageInfo = new FileInfo(ImagePath);

                }
                else
                {
                    NoImage = true;
                }
            }
            else
            {
                NoMetadata = true;
            }

        }

        override public void Save()
        {
            // Create a new XML-Node, if no Metadata exists
            if (NoMetadata || MetaXmlNode == null)
            {
                XmlElement xmlElement = Platform.XmlGamelist.CreateElement("game");
                MetaXmlNode = Platform.XmlGamelist.DocumentElement.AppendChild(xmlElement);

                UpdateXmlNode("path", MetaPath);
                NoMetadata = false;
                Platform.ListRomsWithoutMetadata.Remove(this);
            }

            UpdateXmlNode("name", MetaName);
            UpdateXmlNode("genre", MetaGenre);
            UpdateXmlNode("developer", MetaDeveloper);
            UpdateXmlNode("publisher", MetaPublisher);
            UpdateXmlNode("desc", MetaDesc);
            if (MetaPlaycountInt > 0)
            {
                UpdateXmlNode("playcount", MetaPlaycount);
            }
            else
            {
                UpdateXmlNode("playcount", string.Empty);
            }
            if (MetaPlayersInt > 0)
            {
                UpdateXmlNode("players", MetaPlayers);
            }
            else
            {
                UpdateXmlNode("players", string.Empty);
            }
            if (MetaReleasdateDatetime != DateTime.MinValue)
            {
                string rlsDate = MetaReleasdateDatetime.Year.ToString();
                rlsDate += Library.Add0(MetaReleasdateDatetime.Month.ToString());
                rlsDate += Library.Add0(MetaReleasdateDatetime.Day.ToString());
                rlsDate += "T000000";
                UpdateXmlNode("releasedate", rlsDate);
            }
            else
            {
                UpdateXmlNode("releasedate", string.Empty);
            }

            Platform.XmlGamelist.Save(Platform.PathGamelist);
        }        
    }
}
