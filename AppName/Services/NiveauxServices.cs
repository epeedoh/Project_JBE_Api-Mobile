using AppName.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Services
{
    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]
    public class NiveauxServices
    {

        ObservableCollection<Question> Questions;
        ObservableCollection<PropositionReponse> PropositionReponses;
        ObservableCollection<Reponse> BonneReponses;

        JbeServiceGenerique data;

        public List<Theme> ListeThemeByIdStage { get; set; }
        public List<Niveau> ListNiveauById { get; set; }


        List<Reponse> ListBonneReponses { get; set; }



        public NiveauxServices()
        {
            //Questions = new List<Question>();

        }



        public string GetNiveau()
        {
            return null;
        }

        public ObservableCollection<Question> GetListQuestionNiveauEnCour()
        {

            Questions = new ObservableCollection<Question>() {

                new Question
                {
                    QuestionID = 1,
                    Libelle ="Le 2ème livre de la Bible a été écrit par Moïse ",
                    Point = 1,
                    Active = false,
                    NiveauID = 1
                },
                  new Question
                {
                    QuestionID = 2,
                    Libelle ="Jude est un livre de l’AT",
                       Point = 1,
                    Active = false,
                      NiveauID = 1
                },
                //     new Question
                //{
                //    Id = 3,
                //    Libelle ="Le Nouveau Testament original a été écrit en Hébreux",
                //       Point = 1,
                //    Active = false,
                //      IdNiveau = 1
                //},
                //  new Question
                //{
                //    Id = 4,
                //    Libelle ="L’auteur de Lévitique s’appelle Lévi",
                //       Point = 1,
                //    Active = false,
                //      IdNiveau = 1
                //},
                //     new Question
                //{
                //    Id = 5,
                //    Libelle ="L’auteur des Actes des apôtres s’appelle Luc",
                //       Point = 1,
                //    Active = false,
                //      IdNiveau = 1
                //}

            };

            return Questions;
        }

        public ObservableCollection<Question> GetListQuestionByNiveauID(int NiveauID)
        {
            Questions = new ObservableCollection<Question>() {

                new Question
                {
                    QuestionID = 1,
                    Libelle ="Le 2ème livre de la Bible a été écrit par Moïse ",
                    Point = 1,
                    Active = false,
                    NiveauID = 1
                },
                  new Question
                {
                    QuestionID = 2,
                    Libelle ="Jude est un livre de l’AT",
                       Point = 1,
                    Active = false,
                      NiveauID = 1
                },
                //     new Question
                //{
                //    Id = 3,
                //    Libelle ="Le Nouveau Testament original a été écrit en Hébreux",
                //       Point = 1,
                //    Active = false,
                //      IdNiveau = 1
                //},
                //  new Question
                //{
                //    Id = 4,
                //    Libelle ="L’auteur de Lévitique s’appelle Lévi",
                //       Point = 1,
                //    Active = false,
                //      IdNiveau = 1
                //},
                //     new Question
                //{
                //    Id = 5,
                //    Libelle ="L’auteur des Actes des apôtres s’appelle Luc",
                //       Point = 1,
                //    Active = false,
                //      IdNiveau = 1
                //}
                new Question
                {
                 QuestionID = 6,
                 Active = false,
                 Libelle = "La Bible est communément appelée :",
                 Point = 1,
                 NiveauID = 2
                },
                new Question
                {
                 QuestionID = 7,
                 Active = false,
                 Libelle = "La Bible est constituée de combien de Livres :",
                 Point = 1,
                 NiveauID = 2
                },
                     new Question
                {
                 QuestionID = 8,
                 Active = false,
                 Libelle = "L’Ancien testament contient combien de livres :",
                 Point = 1,
                 NiveauID = 2
                },
                       new Question
                {
                 QuestionID = 9,
                 Active = false,
                 Libelle = "La première traduction s’appelle :",
                 Point = 1,
                 NiveauID = 2
                },
      new Question
                {
                 QuestionID = 10,
                 Active = false,
                 Libelle = "Le cinquième livre de la Bible s’appelle :",
                 Point = 1,
                 NiveauID = 2
                },

      //***
            new Question
                {
                 QuestionID = 11,
                 Active = false,
                 Libelle = "Au ………………………, Dieu crée le ciel et la terre.",
                 Point = 1,
                 NiveauID = 3
                },
                   new Question
                {
                 QuestionID = 12,
                 Active = false,
                 Libelle = "Lorsque l’Eternel eut achevé de parler à Moïse sur le mont Sinaï, il lui donna les deux ...... du témoignage, tables de pierre, écrites du doigt de Dieu.",
                 Point = 1,
                 NiveauID = 3
                },


        };

          var ListQuestion =  Questions.Where(q => q.NiveauID == NiveauID).ToList();
            var QuestionToLoad = new ObservableCollection<Question>();

            foreach(var item in ListQuestion)
            {
                QuestionToLoad.Add(item);
                //var anQuestion = new Question
                //{
                //    Active = item.
                //}
            }

            return QuestionToLoad;
        }


        public ObservableCollection<PropositionReponse> GetAllListPropositionReponse()
        {

            PropositionReponses = new ObservableCollection<PropositionReponse>() {

                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai",
                    IdQestion = 1
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 1
                },


                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai",
                    IdQestion = 2
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 2
                },


                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai",
                    IdQestion = 3
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 3
                },



                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai",
                    IdQestion = 4
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 4
                },



                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai",
                    IdQestion = 5
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 5
                },

                  //**

                      new PropositionReponse
                {
                    Id = 3,
                    Libelle ="La Parole du Christ",
                      IdQestion = 6
                },
                                new PropositionReponse
                {
                    Id = 4,
                    Libelle ="La Parole des apôtres",
                      IdQestion = 6
                },
                      new PropositionReponse
                {
                    Id = 5,
                    Libelle ="La Parole de Dieu",
                      IdQestion = 6
                },
                 new PropositionReponse
                {
                    Id = 6,
                    Libelle ="Parole des chrétiens",
                      IdQestion = 6
                },

                 //**
                    new PropositionReponse
                {
                    Id = 7,
                    Libelle ="70",
                      IdQestion = 7
                },
                          new PropositionReponse
                {
                    Id = 8,
                    Libelle ="72",
                      IdQestion = 7
                },
                     new PropositionReponse
                {
                    Id = 9,
                    Libelle ="66",
                      IdQestion = 7
                },
                          new PropositionReponse
                {
                    Id = 10,
                    Libelle ="77",
                      IdQestion = 7
                },
            };

            return PropositionReponses;
        }

        public ObservableCollection<PropositionReponse> GetAllListPropositionReponseByQuestionID(int QuestionID)
        {

           var PropositionReponsesToSend = new ObservableCollection<PropositionReponse>();

            PropositionReponses = new ObservableCollection<PropositionReponse>() {

                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai",
                    IdQestion = 1
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 1
                },


                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai",
                    IdQestion = 2
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 2
                },


                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai",
                    IdQestion = 3
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 3
                },



                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai",
                    IdQestion = 4
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 4
                },



                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai",
                    IdQestion = 5
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 5
                },

                  //**

                      new PropositionReponse
                {
                    Id = 3,
                    Libelle ="La Parole du Christ",
                      IdQestion = 6
                },
                                new PropositionReponse
                {
                    Id = 4,
                    Libelle ="La Parole des apôtres",
                      IdQestion = 6
                },
                      new PropositionReponse
                {
                    Id = 5,
                    Libelle ="La Parole de Dieu",
                      IdQestion = 6
                },
                 new PropositionReponse
                {
                    Id = 6,
                    Libelle ="Parole des chrétiens",
                      IdQestion = 6
                },

                 //**
                    new PropositionReponse
                {
                    Id = 7,
                    Libelle ="70",
                      IdQestion = 7
                },
                          new PropositionReponse
                {
                    Id = 8,
                    Libelle ="72",
                      IdQestion = 7
                },
                     new PropositionReponse
                {
                    Id = 9,
                    Libelle ="66",
                      IdQestion = 7
                },
                          new PropositionReponse
                {
                    Id = 10,
                    Libelle ="77",
                      IdQestion = 7
                },
            };

            //return PropositionReponses;

            // var ListQuestion = Questions.Where(q => q.NiveauID == NiveauID).ToList();

            var listPropositionReponse = PropositionReponses.Where(r => r.IdQestion == QuestionID).ToList();

            foreach(var item in listPropositionReponse)
            {
                PropositionReponsesToSend.Add(item);
            }

            return PropositionReponsesToSend;

        }


        public List<Reponse> GetAllListBonneReponse(int IdQuestion)
        {

            BonneReponses = new ObservableCollection<Reponse>() {

                new Reponse
                {
                    Id = 1,
                    Libelle ="Vrai ",
                    IdQuestion = 1
                },
                  new Reponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQuestion = 2
                },


                new Reponse
                {
                    Id = 3,
                    Libelle ="Faux",
                    IdQuestion = 3
                },
                  new Reponse
                {
                    Id = 4,
                    Libelle ="Faux",
                      IdQuestion = 4
                },


                new Reponse
                {
                    Id = 5,
                    Libelle ="Faux",
                    IdQuestion = 5
                },
                   //**

                      new Reponse
                {
                    Id = 5,
                    Libelle ="La Parole de Dieu",
                      IdQuestion = 6
                },

                 //**
               
                     new Reponse
                {
                    Id = 9,
                    Libelle ="66",
                      IdQuestion = 7
                }
            };


            ListBonneReponses = BonneReponses.Where(q => q.IdQuestion == IdQuestion).ToList();

            return ListBonneReponses;
        }



        public List<Theme> GetThemeByIdStage(int IdStage)
        {



          var ListeTheme = new List<Theme>()
            {
                new Theme
                {
                    ThemeID = 1,
                    Libelle = "Theme 1: Généralités sur la bible ",
                    Active = true,
                    StageID = 1,
                    Point = 5
                    
                },
                new Theme
                {
                    ThemeID = 2,
                    Libelle = "Theme 2: Généralités sur la foi",
                    Active = false,
                    StageID = 1
                },
                new Theme
                {
                    ThemeID = 3,
                    Libelle = "Theme 3: Généralités sur la divinité",
                    Active = false,
                    StageID = 1
                },
                new Theme
                {
                    ThemeID = 4,
                    Libelle = "Theme 4: Généralités sur la grace",
                    Active = false,
                    StageID = 1
                }
            };

         

            ListeThemeByIdStage = ListeTheme.Where(t => t.StageID == IdStage).ToList();

            return ListeThemeByIdStage;
        }


        public List<Theme> SaveTheme()
        {
            var ListeTheme = new List<Theme>()
            {
                new Theme
                {
                    ThemeID = 1,
                    CodeTheme = "Theme_1",
                    Libelle = "Theme 1: Généralités sur la bible ",
                    Active = true,
                    StageID = 1,
                    Point = 2,
                    CodeThemeSuivant ="Theme_2",
                    ThemeActiveBackgroundColor = "Green"

                },
                new Theme
                {
                    ThemeID = 2,
                     CodeTheme = "Theme_2",
                    Libelle = "Theme 2: Généralités sur la foi",
                    Active = false,
                    StageID = 1,
                      CodeThemeSuivant ="Theme_3",
                },
                new Theme
                {
                    ThemeID = 3,
                     CodeTheme = "Theme_3",
                    Libelle = "Theme 3: Généralités sur la divinité",
                    Active = false,
                    StageID = 1,
                    CodeThemeSuivant ="Theme_4"
                },
                new Theme
                {
                    ThemeID = 4,
                     CodeTheme = "Theme_4",
                    Libelle = "Theme 4: Généralités sur la grace",
                    Active = false,
                    StageID = 1,
                    CodeThemeSuivant ="Theme_5"
                }
            };

            //foreach(var item in ListeTheme)
            //{
            //    App.Database.SaveThemeAsync(item);
            //}

            //App.Database.SaveThemeAsync(ListeTheme);

            // ListeThemeByIdStage = ListeTheme.Where(t => t.IdStage == IdStage).ToList();

            //  return ListeThemeByIdStage;
            return null;
        }

        public async Task<int> UpdateThemeStatut(Theme theme)
        {
            var data = await App.Database.UpdateThemeStatut(theme);
            return data;
        }

        public string ActiveNextTheme(string CodeThemeSuivant)
        {
            var data =  App.Database.ActiveNextTheme(CodeThemeSuivant);
            return data;
        }

        public async Task<List<Theme>> GetThemesAsync()
        {
            var data = await App.Database.GetThemeAsync();

            return data;
        }

        //public List<Stage> GetAllStage(int IdStage)
        //{
        //    var ListeNiveau = new List<Niveau>()
        //    {
        //        new Niveau
        //        {
        //            Id = 1,
        //            Libelle = "Niveau 1",
        //             Active = true,
        //            IdTheme = 1

        //        },
        //        new Niveau
        //        {
        //            Id = 2,
        //            Libelle = "Niveau 2",
        //             Active = false,
        //                IdTheme = 1
        //        },
        //        new Niveau
        //        {
        //            Id = 3,
        //            Libelle = "Niveau 3",
        //             Active = false,
        //              IdTheme = 1
        //        },
        //        new Niveau
        //        {
        //            Id = 4,
        //            Libelle = "Niveau 4",
        //            Active = false,
        //           IdTheme = 1
        //        }
        //    };



        //    ListNiveauById = ListeNiveau.Where(t => t.IdTheme == IdTheme).ToList();

        //    return ListNiveauById;
        //}



        public List<Niveau> GetNiveauByIdTheme(int IdTheme)
        {
            var ListeNiveau = new List<Niveau>()
            {
                new Niveau
                {
                    NiveauID = 1,
                    Libelle = "Niveau 1",
                     Active = true,
                    ThemeID = 1

                },
                new Niveau
                {
                    NiveauID = 2,
                    Libelle = "Niveau 2",
                     Active = false,
                        ThemeID = 1
                },
                new Niveau
                {
                    NiveauID = 3,
                    Libelle = "Niveau 3",
                     Active = false,
                      ThemeID = 1
                },
                new Niveau
                {
                    NiveauID = 4,
                    Libelle = "Niveau 4",
                    Active = false,
                   ThemeID = 1
                }
            };



            ListNiveauById = ListeNiveau.Where(t => t.ThemeID == IdTheme).ToList();

            return ListNiveauById;
        }


        public List<PropositionReponse> GetListPropositionReponseByQuestionId(int IdQuestion)
        {
            // var list   GetAllListPropositionReponse();
            PropositionReponses = new ObservableCollection<PropositionReponse>() {

                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai ",
                    IdQestion = 1
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 1
                },


                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai ",
                    IdQestion = 2
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 2
                },


                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai ",
                    IdQestion = 3
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 3
                },



                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai ",
                    IdQestion = 4
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 4
                },



                new PropositionReponse
                {
                    Id = 1,
                    Libelle ="Vrai ",
                    IdQestion = 5
                },
                  new PropositionReponse
                {
                    Id = 2,
                    Libelle ="Faux",
                      IdQestion = 5
                },

            };

            var listProposition = PropositionReponses.Where(q => q.IdQestion == IdQuestion).ToList();
            return listProposition;
        }

        //public Niveau GetNiveauDepart()
        //{
        //    var niveau = new ObservableCollection<Niveau>()
        //    {
        //        Niveau
        //    }
        //}
    }
}


