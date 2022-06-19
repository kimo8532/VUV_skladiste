﻿using System;

                if (XmlartikliNode.Attributes["Naziv"].Value == "")
                {
                    throw new Iznimka("Izdatnica nema artikle! Izdatnica.xml");
                }
                {
                    throw new Iznimka("Izdatnica nema artikle! Izdatnica.xml");
                }
            {
                List<Primka> primkaList = new List<Primka>();
                string xmlPrimka = "";
                StreamReader sr = new StreamReader("Primka.xml");
                using (sr)
                {
                    xmlPrimka = sr.ReadToEnd();
                }
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlPrimka);
                XmlNodeList Xmlprimka = xmlDocument.SelectNodes("//Primke/Primka");
                List<Artikl> noviartikli = new List<Artikl>();
                List<decimal> kolicina = new List<decimal>();
                foreach (XmlNode primka in Xmlprimka)
                {
                    if (primka.Attributes["Istonirano"] == null)
                    {
                        noviartikli.Clear();
                        foreach (XmlNode xmlartikl in primka.ChildNodes)
                        {
                            if (Artikl.DohvatiArtikl(xmlartikl.Attributes["Sifra"].Value) == null)
                            {
                                throw new Iznimka("Artikl ne postoji");
                            }
                            else
                            {
                                noviartikli.Add(Artikl.DohvatiArtikl(xmlartikl.Attributes["Sifra"].Value));
                                kolicina.Add(Convert.ToInt32(xmlartikl.Attributes["Kolicina"].Value));
                            }

                        }
                        primkaList.Add(new Primka(primka.Attributes["Datum"].Value, noviartikli, kolicina));
                    }
                }
                return primkaList;
            }
            catch (Iznimka i)
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i.Message);
                Console.ResetColor();
                return null;
            }
            {
                List<Izdatnica> IzdatnicaList = new List<Izdatnica>();
                string xmlIzdatnica = "";
                StreamReader sr = new StreamReader("Izdatnica.xml");
                using (sr)
                {
                    xmlIzdatnica = sr.ReadToEnd();
                }
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlIzdatnica);
                XmlNodeList XmlIzdatnica = xmlDocument.SelectNodes("//Izdatnice/Izdatnica");
                List<Artikl> noviartikli = new List<Artikl>();
                List<decimal> kolicina = new List<decimal>();
                foreach (XmlNode izdatnica in XmlIzdatnica)
                {
                    if (izdatnica.Attributes["Istonirano"] == null)
                    {
                        noviartikli.Clear();
                        foreach (XmlNode xmlartikl in izdatnica.ChildNodes)
                        {
                            if (Artikl.DohvatiArtikl(xmlartikl.Attributes["Sifra"].Value) == null)
                            {
                                throw new Iznimka("Artikl ne postoji");
                            }
                            else
                            {
                                noviartikli.Add(Artikl.DohvatiArtikl(xmlartikl.Attributes["Sifra"].Value));
                                kolicina.Add(Convert.ToInt32(xmlartikl.Attributes["Kolicina"].Value));
                            }

                        }
                        IzdatnicaList.Add(new Izdatnica(izdatnica.Attributes["Datum"].Value, noviartikli, kolicina));
                    }
                }
                return IzdatnicaList;
            }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i.Message);
                Console.ResetColor();
                return null;
            }
                foreach (XmlNode primka in xmlprimka)

                            kolicinaulaz += decimal.Parse(artikluprimki.Attributes["Kolicina"].Value);
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("Primka.xml");
            XmlNodeList Primke = xmlDocument.SelectNodes("/Primke/Primka");
            XmlAttribute atribut = xmlDocument.CreateAttribute("Istonirano");
            atribut.Value = "true";
            foreach (XmlNode PrimkeNode in Primke)
            {
                if ((PrimkeNode.Attributes["Datum"].Value == p.Datum) && (PrimkeNode.Attributes["IznosUlaz"].Value == p.IznosUlaz.ToString()))
                {
                    PrimkeNode.Attributes.Append(atribut);
                }
            }
            xmlDocument.Save("Primka.xml");
        }
        //Dodaje atribut istonirano izdatnici Istonirano, tim podatkima ne mozemo vise pristupiti osim modifikacije baze
        public static void DodajAtributIstoniranIzdatnici(Izdatnica p)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("Izdatnica.xml");
            XmlNodeList Izdatnice = xmlDocument.SelectNodes("/Izdatnice/Izdatnica");
            XmlAttribute atribut = xmlDocument.CreateAttribute("Istonirano");
            atribut.Value = true.ToString();
            foreach (XmlNode IzdatnicaNode in Izdatnice)
            {
                if ((IzdatnicaNode.Attributes["Datum"].Value == p.Datum) && (IzdatnicaNode.Attributes["IznosIzlaz"].Value == p.IznosIzlaz.ToString()))
                {
                    IzdatnicaNode.Attributes.Append(atribut);
                }
            }
            xmlDocument.Save("Izdatnica.xml");
        }
        //Ispisuje trenutno stanje skladista
        public static List<Artikl> StanjeSkladista()
                foreach (XmlNode primka in xmlprimka)
                            kolicinaulaz += decimal.Parse(artikluprimki.Attributes["Kolicina"].Value);
                {
                    if (artikl.Attributes["JMJ"].Value == "")
                    {
                        dostupni.Add(new Artikl(artikl.Attributes["Sifra"].Value, artikl.Attributes["Naziv"].Value, $"{artikl.LastChild.Attributes["Debljina"].Value}x{artikl.LastChild.Attributes["Sirina"].Value}x{artikl.LastChild.Attributes["Duzina"].Value} " +
                        $"{artikl.LastChild.Attributes["MjernaJedinica"].Value}", $"{artikl.Attributes["Cijena"].Value}"));
                    }
                    else
                    {
                        dostupni.Add(new Artikl(artikl.Attributes["Sifra"].Value, artikl.Attributes["Naziv"].Value, $"{artikl.LastChild.Attributes["Debljina"].Value}x{artikl.LastChild.Attributes["Sirina"].Value}x{artikl.LastChild.Attributes["Duzina"].Value} " +
                        $"{artikl.LastChild.Attributes["MjernaJedinica"].Value}", $"{artikl.Attributes["Cijena"].Value}/{artikl.Attributes["JMJ"].Value}"));
                    }
                }
        }
        //Daje nam pristup trenutnoj kolicini svakog artikla
        public static List<decimal> KolicinaArtikala()
        {
            List<decimal> dostupni = new List<decimal>();
                foreach (XmlNode primka in xmlprimka)
                            kolicinaulaz += decimal.Parse(artikluprimki.Attributes["Kolicina"].Value);
                {
                    dostupni.Add(kolicinaulaz - kolicinaizlaz);
                }
        }
        //Azurira artikl
        public static void AzurirajArtikl(string keyword, string promjena, string sifra)
        {
            XmlDocument dokument = new XmlDocument();
            dokument.Load("Artikl.xml");
            XmlNodeList xmlartikli = dokument.SelectNodes("//Artikli/Artikl");
            foreach(XmlNode artikl in xmlartikli)
            {
                if(artikl.Attributes["Sifra"].Value == sifra)
                {
                    artikl.Attributes[keyword].Value = promjena;
                    dokument.Save("Artikl.xml");
                }    
            }
            XML.IzracunajIznos();
        }
    }
}