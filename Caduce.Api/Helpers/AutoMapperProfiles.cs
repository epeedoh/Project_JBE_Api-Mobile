using AutoMapper;
using Caduce.Api.Dto;
using Caduce.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caduce.Api.Helpers
{
    public class AutoMapperProfiles: Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<Personne, PersonneDto>()
             .ForMember(dest => dest.Image, opt =>{
                 opt.ResolveUsing(d => d.Image.ByteToString());
             });
            CreateMap<EntrepriseDto, Entreprise>()
            .ForMember(dest => dest.Logo, opt => {
                opt.ResolveUsing(d => d.Logo.StringToByte());
            });

            CreateMap<Entreprise, EntrepriseDto>()
            .ForMember(dest => dest.Logo, opt => {
                opt.ResolveUsing(d => d.Logo.ByteToString());
            })
            .ForMember(dest => dest.NombreService, opt => {
                opt.ResolveUsing(d => d.services.Count);
            })
            .ForMember(dest => dest.NombreUser, opt => {
                opt.ResolveUsing(d => d.utilisateurs.Count);
            });

            CreateMap<Entreprise, DetailEntrepriseDto>()
            .ForMember(dest => dest.entreprise, opt => {
                opt.MapFrom(src => Mapper.Map<EntrepriseDto>(src));
            })
            .ForMember(dest => dest.users, opt => {
                opt.MapFrom(src => Mapper.Map<List<UserDto>>(src.utilisateurs));
            })
             .ForMember(dest => dest.services, opt => {
                 opt.MapFrom(src => Mapper.Map<List<ServiceDto>>(src.services));
             });

            CreateMap<Pays, PaysDto>()
            .ForMember(dest => dest.Image, opt => {
                opt.ResolveUsing(d => d.Image.ByteToString());
            });

            CreateMap<PaysDto, Pays>()
            .ForMember(dest => dest.Image, opt => {
                opt.ResolveUsing(d => d.Image.StringToByte());
            });
     

m



            CreateMap<List<Region>, DetailsPaysRegionDto>()
            .ForMember(dest => dest.pays, opt => {
                opt.MapFrom(src => Mapper.Map<PaysDto>(src.FirstOrDefault().pays));
            })
            .ForMember(dest => dest.Region, opt => {
                opt.MapFrom(src => Mapper.Map<List<RegionDto>>(src));
            });

            CreateMap<List<Entreprise>, DetailsPaysEntrepriseDto>()
           .ForMember(dest => dest.pays, opt => {
               opt.MapFrom(src => Mapper.Map<PaysDto>(src.FirstOrDefault().pays));
           })
           .ForMember(dest => dest.entreprises, opt => {
               opt.MapFrom(src => Mapper.Map<List<EntrepriseDto>>(src));
           });

            CreateMap<Pays, DetailsPays>()
            .ForMember(dest => dest.pays, opt => {
                opt.MapFrom(src => Mapper.Map<PaysDto>(src));
            })
            .ForMember(dest => dest.entreprises, opt => {
                opt.MapFrom(src => Mapper.Map<List<EntrepriseDto>>(src.entreprise));
            })
            .ForMember(dest => dest.Regions, opt => {
                opt.MapFrom(src => Mapper.Map<List<RegionDto>>(src.regions));
            })
            .ForMember(dest => dest.Assureurs, opt => {
                opt.MapFrom(src => Mapper.Map<List<AssureurDto>>(src.assureurs));
            });

            CreateMap<RegionDto, Region>();
            CreateMap<Region, RegionDto>();

            CreateMap<SexeDto, Sexe>();
            CreateMap<Sexe, SexeDto>();

            CreateMap<Sexe, OptionDto>()
             .ForMember(dest => dest.label, opt => {
                 opt.ResolveUsing(d => d.Libelle);
             })
           .ForMember(dest => dest.value, opt => {
               opt.ResolveUsing(d => d.CodeSexe);
           });

            CreateMap<Region, OptionDto>()
              .ForMember(dest => dest.label, opt => {
                  opt.ResolveUsing(d => d.Libelle);
              })
            .ForMember(dest => dest.value, opt => {
                opt.ResolveUsing(d => d.CodeRegion);
            });

            CreateMap<EntrepriseToRegisterDto, Entreprise>()
             .ForMember(dest => dest.Logo, opt => {
                 opt.ResolveUsing(d => d.LogoEntreprise.StringToByte());
             })
           .ForMember(dest => dest.Nom, opt => {
               opt.ResolveUsing(d => d.NomEntreprise);
           });

            CreateMap<EntrepriseToRegisterDto, Personne>()
            .ForMember(dest => dest.NomComplet, opt => {
                opt.ResolveUsing(d => d.Nom.Nomcomplet(d.Prenoms));
            })
             .ForMember(dest => dest.Telephone, opt => {
                 opt.ResolveUsing(d => d.TelephoneUser);
             })
           ;

            CreateMap<EntrepriseToRegisterDto, Utilisateur>()
             .ForMember(dest => dest.Image, opt => {
                 opt.ResolveUsing(d => d.ImageUser.StringToByte());
             });
            /* .ForMember(dest => dest.personne, opt=> {
                 opt.MapFrom(src=> Mapper.Map<Personne>(src));
             });*/



            CreateMap<Utilisateur, UserDto>()
            .ForMember(dest => dest.Imageuser, opt => {
                opt.ResolveUsing(d => d.Image.ByteToString());
            }).ForMember(dest => dest.Entreprise, opt => {
                opt.ResolveUsing(d => d.entreprise.Nom);
            }).ForMember(dest => dest.CodeEntreprise, opt => {
                opt.ResolveUsing(d => d.entreprise.CodeEntreprise);
            }).ForMember(dest => dest.ImageEntreprise, opt => {
                opt.ResolveUsing(d => d.entreprise.Logo.ByteToString());
            }).ForMember(dest => dest.Entreprise, opt => {
                opt.ResolveUsing(d => d.entreprise.Nom);
            }).ForMember(dest => dest.Pays, opt => {
                opt.ResolveUsing(d => d.entreprise.pays.Libelle);
            }).ForMember(dest => dest.CodePays, opt => {
                opt.ResolveUsing(d => d.entreprise.CodePays);
            }).ForMember(dest => dest.Domicile, opt => {
                opt.ResolveUsing(d => d.personne.Domicile);
            }).ForMember(dest => dest.Telephone, opt => {
                opt.ResolveUsing(d => d.personne.Telephone);
            }).ForMember(dest => dest.DateNaissance, opt => {
                opt.ResolveUsing(d => d.personne.DateNaissance);
            }).ForMember(dest => dest.Nom, opt => {
                opt.ResolveUsing(d => d.personne.Nom);
            }).ForMember(dest => dest.Prenoms, opt => {
                opt.ResolveUsing(d => d.personne.Prenoms);
            }).ForMember(dest => dest.NomComplet, opt => {
                opt.ResolveUsing(d => d.personne.NomComplet);
            }).ForMember(dest => dest.Region, opt => {
                opt.ResolveUsing(d => d.personne.region.Libelle);
            }).ForMember(dest => dest.Genre, opt => {
                opt.ResolveUsing(d => d.personne.sexe.Libelle);
            }).ForMember(dest => dest.Profession, opt => {
                opt.ResolveUsing(d => d.personne.Profession.Libelle);
            }).ForMember(dest => dest.Age, opt => {
                opt.ResolveUsing(d => d.personne.DateNaissance.CalculateAge());
            })
            ;



            CreateMap<Personne, UserDto>()
             .ForMember(dest => dest.Region, opt => {
                 opt.ResolveUsing(d => d.region.Libelle);
             }).ForMember(dest => dest.Profession, opt => {
                 opt.ResolveUsing(d => d.Profession.Libelle);
             });
            CreateMap<Entreprise, UserDto>()
             .ForMember(dest => dest.Entreprise, opt => {
                 opt.ResolveUsing(d => d.Nom);
             }).ForMember(dest => dest.Pays, opt => {
                 opt.ResolveUsing(d => d.pays.Libelle);
             }).ForMember(dest => dest.CodePays, opt => {
                 opt.ResolveUsing(d => d.CodePays);
             });

            CreateMap<UserRegisterDto, Utilisateur>()
             .ForMember(dest => dest.Image, opt => {
                 opt.ResolveUsing(d => d.ImageUser.StringToByte());
             }).ForMember(dest => dest.Username, opt => {
                 opt.ResolveUsing(d => d.Username);
             });

            CreateMap<UserRegisterDto, Personne>()
            .ForMember(dest => dest.NomComplet, opt => {
                opt.ResolveUsing(d => d.Nom.Nomcomplet(d.Prenoms));
            })
            .ForMember(dest => dest.Telephone, opt => {
                opt.ResolveUsing(d => d.TelephoneUser);
            });


            //    CreateMap<UserRegisterDto,Personne>()
            // .ForMember(dest => dest.NomComplet, opt=> {
            //     opt.ResolveUsing(d=>d.Nom.Nomcomplet(d.Prenoms));
            // });

            CreateMap<ServiceIn, Service>();
            CreateMap<Service, ServiceDto>()
            .ForMember(dest => dest.NombreUser, opt => {
                opt.ResolveUsing(d => d.utilisateurservices.Count);
            });

            CreateMap<PatientRegister, Patient>();
            CreateMap<PatientRegister, Personne>()
             .ForMember(dest => dest.NomComplet, opt => {
                 opt.ResolveUsing(d => d.Nom.Nomcomplet(d.Prenoms));
             })
             .ForMember(dest => dest.Telephone, opt => {
                 opt.ResolveUsing(d => d.TelephoneUser);
             })
           ;

            CreateMap<MedicamentVenduDto, MedicamentVendu>();
            CreateMap<MedicamentVendu, MedicamentVenduDto>()
                .ForMember(dest => dest.MedicamentId, opt => { opt.ResolveUsing(d => d.medicament.Id); })
                .ForMember(dest => dest.Code, opt => { opt.ResolveUsing(d => d.medicament.Code); })
                .ForMember(dest => dest.Reference, opt => { opt.ResolveUsing(d => d.medicament.Reference); })
                .ForMember(dest => dest.QuantiteDemande, opt => { opt.ResolveUsing(d => d.quantitedemade); })
                .ForMember(dest => dest.QuantiteVendu, opt => { opt.ResolveUsing(d => d.quantitevendu); })
                .ForMember(dest => dest.TotalAPayer, opt => { opt.ResolveUsing(d => d.prixtotal); })
                .ForMember(dest => dest.PrixUnitaire, opt => { opt.ResolveUsing(d => d.prixunitaire); })
                    ;

            CreateMap<BonMedicamentDto, BonMedicament>();
            CreateMap<BonMedicament, BonMedicamentDto>()
                .ForMember(dest => dest.Pharmacien, opt => { opt.ResolveUsing(d => d.utilisateur.personne.NomComplet); })
                .ForMember(dest => dest.patient, opt => { opt.ResolveUsing(d => d.patient.personne.NomComplet); })
                .ForMember(dest => dest.PatientId, opt => { opt.ResolveUsing(d => d.patient.Id); })
                .ForMember(dest => dest.PharmacienId, opt => { opt.ResolveUsing(d => d.utilisateur.id); })
                    ;

            CreateMap<Patient, PatientDto>()
            .ForMember(dest => dest.Entreprise, opt => {
                opt.ResolveUsing(d => d.entreprise.Nom);
            }).ForMember(dest => dest.CodeEntreprise, opt => {
                opt.ResolveUsing(d => d.entreprise.CodeEntreprise);
            })
            .ForMember(dest => dest.Entreprise, opt => {
                opt.ResolveUsing(d => d.entreprise.Nom);
            }).ForMember(dest => dest.Pays, opt => {
                opt.ResolveUsing(d => d.entreprise.pays.Libelle);
            }).ForMember(dest => dest.CodePays, opt => {
                opt.ResolveUsing(d => d.entreprise.CodePays);
            }).ForMember(dest => dest.Domicile, opt => {
                opt.ResolveUsing(d => d.personne.Domicile);
            }).ForMember(dest => dest.Telephone, opt => {
                opt.ResolveUsing(d => d.personne.Telephone);
            }).ForMember(dest => dest.DateNaissance, opt => {
                opt.ResolveUsing(d => d.personne.DateNaissance);
            }).ForMember(dest => dest.Nom, opt => {
                opt.ResolveUsing(d => d.personne.Nom);
            }).ForMember(dest => dest.Prenoms, opt => {
                opt.ResolveUsing(d => d.personne.Prenoms);
            }).ForMember(dest => dest.NomComplet, opt => {
                opt.ResolveUsing(d => d.personne.NomComplet);
            }).ForMember(dest => dest.Region, opt => {
                opt.ResolveUsing(d => d.personne.region.Libelle);
            }).ForMember(dest => dest.Genre, opt => {
                opt.ResolveUsing(d => d.personne.sexe.Libelle);
            }).ForMember(dest => dest.Profession, opt => {
                opt.ResolveUsing(d => d.personne.Profession.Libelle);
            }).ForMember(dest => dest.Age, opt => {
                opt.ResolveUsing(d => d.personne.DateNaissance.CalculateAge());
            }).ForMember(dest => dest.assurance, opt => {
                opt.ResolveUsing(d => d.personne.assureurpersonne.GetAssurance());
            })
            .ForMember(dest => dest.Image, opt => {
                opt.ResolveUsing(d => d.personne.Image.ByteToString());
            })
            .ForMember(dest => dest.Nationalite, opt => {
                opt.ResolveUsing(d => d.personne.pays.Nationalite);
            })
            ;

            CreateMap<EntrepriseToRegisterDto, Compteur>();
            CreateMap<ActeMedical, ActeDto>();
            CreateMap<ActeEntRegisterDto, ActeMedicalEntreprise>();
            CreateMap<ActeMedicalEntreprise, ActeMedicalEntrepriseDto>()
             .ForMember(dest => dest.ActeId, opt => {
                 opt.ResolveUsing(d => d.acteMedical.Id);
             })
              .ForMember(dest => dest.UserCreate, opt => {
                  opt.ResolveUsing(d => d.utilisateur.personne.NomComplet);
              });

            //  CreateMap<ServiceMedicalActeEntreprise,ActeMedicalEntrepriseDto>()
            // .ForMember(dest => dest.ActeId, opt=> {
            // opt.ResolveUsing(d=>d.acteMedical.Id);
            // } )
            //  .ForMember(dest => dest, opt=> {
            // opt.MapFrom(src=> src.acteMedical);
            // } );

            CreateMap<ServicemedicalRegister, ServiceMedical>();
            CreateMap<ServiceMedical, ServiceMedicalDto>()
            .ForMember(dest => dest.UserCreate, opt => {
                opt.ResolveUsing(d => d.utilisateur.personne.NomComplet);
            })
          .ForMember(dest => dest.NbreActe, opt => {
              opt.ResolveUsing(d => d.serviceMedicalActeEntreprise.Count);
          })
         .ForMember(dest => dest.Acte, opt => {
             opt.MapFrom(src => Mapper.Map<List<ActeMedicalEntrepriseDto>>(src.serviceMedicalActeEntreprise.GetActe()));
         })
      .ForMember(dest => dest.Praticiens, opt => {
                 // opt.MapFrom(src=> Mapper.Map<List<PraticientDto>>(src.utilisateurServiceMedicals.GetPraticiens()));
                 opt.MapFrom(src => src.utilisateurServiceMedicals.GetPraticiens());
      })
         ;



            CreateMap<CategorieDto, Categorie>();
            CreateMap<UniteDto, Unite>();
            CreateMap<VoieDto, Voie>();
            CreateMap<NiveauDto, Niveau>();
            CreateMap<MedicamentDto, Medicament>();

            CreateMap<CommandeDto, Commande>();
            CreateMap<Commande, CommandeDto>();

            CreateMap<StockDto, Stock>();

            CreateMap<PharmacienDto, Pharmacien>();
            CreateMap<FournisseurDto, Fournisseur>();
            CreateMap<ApprovisionnementDto, Approvisionnement>();
            CreateMap<VenteDto, Vente>();
            CreateMap<PatientDto, Patient>();

            CreateMap<PharmacienDto, Personne>()
             .ForMember(dest => dest.NomComplet, opt => {
                 opt.ResolveUsing(d => d.Nom.Nomcomplet(d.Prenoms));
             })
             .ForMember(dest => dest.Telephone, opt => {
                 opt.ResolveUsing(d => d.TelephoneUser);
             });

            CreateMap<FournisseurDto, Personne>()
             .ForMember(dest => dest.NomComplet, opt => {
                 opt.ResolveUsing(d => d.Nom.Nomcomplet(d.Prenoms));
             })
             .ForMember(dest => dest.Telephone, opt => {
                 opt.ResolveUsing(d => d.TelephoneUser);
             })
             .ForMember(dest => dest.Telephone, opt => {
                 opt.ResolveUsing(d => d.Contacts);
             });



            CreateMap<Approvisionnement, ApprovisionnementDto>()
            .ForMember(dest => dest.Reference, opt => {
                opt.ResolveUsing(d => d.stock.medicament.Reference);
            }).ForMember(dest => dest.Designation, opt => {
                opt.ResolveUsing(d => d.stock.medicament.Designation);
            }).ForMember(dest => dest.SeuilAlerte, opt => {
                opt.ResolveUsing(d => d.stock.SeuilAlerte);
            }).ForMember(dest => dest.StockResiduel, opt => {
                opt.ResolveUsing(d => d.stock.SeuilMinimum);
            }).ForMember(dest => dest.NomUtilisateur, opt => {
                opt.ResolveUsing(d => d.utilisateur.personne.Nom.Nomcomplet(d.utilisateur.personne.Prenoms));
            });


            CreateMap<Vente, VenteDto>()
            .ForMember(dest => dest.Telephone, opt => {
                opt.ResolveUsing(d => d.patient.personne.Telephone);
            }).ForMember(dest => dest.Utilisateur, opt => {
                opt.ResolveUsing(d => d.pharmacien.personne.Nom.Nomcomplet(d.pharmacien.personne.Prenoms));
            });

            CreateMap<Pharmacien, PharmacienDto>()
            .ForMember(dest => dest.TelephoneUser, opt => {
                opt.ResolveUsing(d => d.personne.Telephone);
            }).ForMember(dest => dest.DateNaissance, opt => {
                opt.ResolveUsing(d => d.personne.DateNaissance);
            }).ForMember(dest => dest.Nom, opt => {
                opt.ResolveUsing(d => d.personne.Nom);
            }).ForMember(dest => dest.Prenoms, opt => {
                opt.ResolveUsing(d => d.personne.Prenoms);
            }).ForMember(dest => dest.CodeRegion, opt => {
                opt.ResolveUsing(d => d.personne.CodeRegion);
            }).ForMember(dest => dest.CodeSexe, opt => {
                opt.ResolveUsing(d => d.personne.CodeSexe);
            }).ForMember(dest => dest.CodeProfession, opt => {
                opt.ResolveUsing(d => d.personne.CodeProfession);
            });


            CreateMap<Fournisseur, FournisseurDto>()
            .ForMember(dest => dest.TelephoneUser, opt => {
                opt.ResolveUsing(d => d.personne.Telephone);
            }).ForMember(dest => dest.DateNaissance, opt => {
                opt.ResolveUsing(d => d.personne.DateNaissance);
            }).ForMember(dest => dest.Nom, opt => {
                opt.ResolveUsing(d => d.personne.Nom);
            }).ForMember(dest => dest.Prenoms, opt => {
                opt.ResolveUsing(d => d.personne.Prenoms);
            }).ForMember(dest => dest.CodeRegion, opt => {
                opt.ResolveUsing(d => d.personne.CodeRegion);
            }).ForMember(dest => dest.CodeSexe, opt => {
                opt.ResolveUsing(d => d.personne.CodeSexe);
            }).ForMember(dest => dest.NomEntreprise, opt => {
                opt.ResolveUsing(d => d.NomEntreprise);
            }).ForMember(dest => dest.CodeProfession, opt => {
                opt.ResolveUsing(d => d.personne.CodeProfession);
            });

            CreateMap<Stock, EtatStock>()
            .ForMember(dest => dest.MedicamentId, opt => {
                opt.ResolveUsing(d => d.MedicamentId);
            }).ForMember(dest => dest.StockId, opt => {
                opt.ResolveUsing(d => d.Id);
            })
            .ForMember(dest => dest.QuantiteMinimale, opt => {
                opt.ResolveUsing(d => d.SeuilMinimum);
            })
            .ForMember(dest => dest.SeuilAlerte, opt => {
                opt.ResolveUsing(d => d.SeuilAlerte);
            })
            .ForMember(dest => dest.TotalEntrees, opt => {
                opt.ResolveUsing(d => d.SeuilMinimum);
            })
            .ForMember(dest => dest.TotalVendus, opt => {
                opt.ResolveUsing(d => d.SeuilMinimum);
            })
            .ForMember(dest => dest.Designation, opt => {
                opt.ResolveUsing(d => d.medicament.Designation);
            })
            .ForMember(dest => dest.TotalEntrees, opt => {
                opt.ResolveUsing(d => d.approvisionnements.Count);
            });

            //  })
            // .ForMember(dest => dest.QuantiteResiduelle, opt => {
            //     opt.ResolveUsing(d => (d.approvisionnements.Count - d.ventes.Count));
            // })
            // ;

            CreateMap<Medicament, MedicamentDto>();



            CreateMap<RoleTypeRegister, RoleType>();
            CreateMap<RoleType, RoleTypeDto>();

            CreateMap<prestationpatientregister, Prestation>()
         .ForMember(dest => dest.ActeMedicalEntrepriseId, opt => {
             opt.ResolveUsing(d => d.acteId);
         }).ForMember(dest => dest.ServiceMedicalId, opt => {
             opt.ResolveUsing(d => d.serviceId);
         })
         .ForMember(dest => dest.libelle, opt => {
             opt.ResolveUsing(d => d.acte);
         })
          .ForMember(dest => dest.Solde, opt => {
              opt.ResolveUsing(d => d.prixTotal);
          })
        ;

            CreateMap<assurancepatientdto, AssureurPersonne>()
            .ForMember(dest => dest.TauxCouverture, opt => {
                opt.ResolveUsing(d => d.Taux);
            }).ForMember(dest => dest.NumeroCarte, opt => {
                opt.ResolveUsing(d => d.NumCarte);
            })
           ;
            CreateMap<AssureurPersonne, assurancepatientdto>()
                 .ForMember(dest => dest.Taux, opt =>
                 {
                     opt.ResolveUsing(d => d.TauxCouverture);
                 }).ForMember(dest => dest.NumCarte, opt =>
                 {
                     opt.ResolveUsing(d => d.NumeroCarte);
                 })
                 .ForMember(dest => dest.AssuranceId, opt =>
                 {
                     opt.ResolveUsing(d => d.Id);
                 })
                  .ForMember(dest => dest.NomAssureur, opt =>
                  {
                      opt.ResolveUsing(d => d.assureur.Nom);
                  });
            CreateMap<ActeType, ActeTypeDto>();
            CreateMap<ActeTypeDto, ActeType>();
            CreateMap<Prestation, PrestationDto>()
                .ForMember(dest => dest.UserCreate, opt => {
                    opt.ResolveUsing(d => d.utilisateur.personne.NomComplet);
                }).ForMember(dest => dest.StatutId, opt => {
                    opt.ResolveUsing(d => d.statutPrestations.FirstOrDefault().Id);
                })
            .ForMember(dest => dest.Statut, opt => {
                opt.ResolveUsing(d => d.statutPrestations.FirstOrDefault(x => x.PeriodeFin is null).Statut);
            }).ForMember(dest => dest.DateStatut, opt => {
                opt.ResolveUsing(d => d.statutPrestations.FirstOrDefault(x => x.PeriodeFin is null).PeriodeDebut);
            }).ForMember(dest => dest.CodeStatut, opt => {
                opt.ResolveUsing(d => d.statutPrestations.FirstOrDefault(x => x.PeriodeFin is null).CodeStatut);
            })
            .ForMember(dest => dest.assurance, opt => {
                opt.ResolveUsing(d => d.assurance.GetAssurancePrestation());
            }).ForMember(dest => dest.Entreprise, opt => {
                opt.ResolveUsing(d => Mapper.Map<EntrepriseDto>(d.entreprise));
            })
            .ForMember(dest => dest.Patient, opt => {
                opt.ResolveUsing(d => Mapper.Map<PatientDto>(d.patient));
            })
           ;

            CreateMap<MoyenPaiementDto, MoyenPaiementType>()
               .ForMember(dest => dest.Icon, opt => {
                   opt.ResolveUsing(d => d.Icon.StringToByte());
               });
            CreateMap<MoyenPaiementType, MoyenPaiementDto>()
             .ForMember(dest => dest.Icon, opt => {
                 opt.ResolveUsing(d => d.Icon.ByteToString());
             });
            CreateMap<MoyenPaiementEntreprise, MoyenPaiementEntrepriseDto>()
             .ForMember(dest => dest.Icon, opt => {
                 opt.ResolveUsing(d => d.Icon.ByteToString());
             })
           .ForMember(dest => dest.UserCreate, opt => {
               opt.ResolveUsing(d => d.utilisateur.personne.NomComplet);
           });

            CreateMap<EncaissementRegisteurDto, Encaissement>()
           ;

            CreateMap<PrestationPaiementDto, EncaissementPrestations>()
           ;

            CreateMap<Encaissement, EncaissementDto>()
             .ForMember(dest => dest.usercreate, opt => {
                 opt.ResolveUsing(d => d.utilisateur.personne.NomComplet);
             })
           ;

            CreateMap<ClientCreateDto, CompteClient>()
                .ForMember(dest => dest.Username, opt => {
                    opt.ResolveUsing(d => d.Username);
                });

            CreateMap<Consultation, ConsultationDto>()
          .ForMember(dest => dest.numeroPrestation, opt => {
              opt.ResolveUsing(d => d.prestation.numeroPrestation);
          })
           .ForMember(dest => dest.ServiceMedicalId, opt => {
               opt.ResolveUsing(d => d.prestation.ServiceMedicalId);
           })
            .ForMember(dest => dest.service, opt => {
                opt.ResolveUsing(d => d.prestation.service);
            })
            .ForMember(dest => dest.ActeMedicalEntrepriseId, opt => {
                opt.ResolveUsing(d => d.prestation.ActeMedicalEntrepriseId);
            })
            .ForMember(dest => dest.libelle, opt => {
                opt.ResolveUsing(d => d.prestation.libelle);
            })
           .ForMember(dest => dest.UserCreate, opt => {
               opt.ResolveUsing(d => d.utilisateur.personne.NomComplet);
           }).ForMember(dest => dest.StatutId, opt => {
               opt.ResolveUsing(d => d.statutConsultations.FirstOrDefault().Id);
           })
            .ForMember(dest => dest.Statut, opt => {
                opt.ResolveUsing(d => d.statutConsultations.FirstOrDefault(x => x.PeriodeFin is null).Statut);
            }).ForMember(dest => dest.DateStatut, opt => {
                opt.ResolveUsing(d => d.statutConsultations.FirstOrDefault(x => x.PeriodeFin is null).PeriodeDebut);
            }).ForMember(dest => dest.CodeStatut, opt => {
                opt.ResolveUsing(d => d.statutConsultations.FirstOrDefault(x => x.PeriodeFin is null).CodeStatut);
            })
            .ForMember(dest => dest.assurance, opt => {
                opt.ResolveUsing(d => d.prestation.assurance.GetAssurancePrestation());
            }).ForMember(dest => dest.Entreprise, opt => {
                opt.ResolveUsing(d => Mapper.Map<EntrepriseDto>(d.prestation.entreprise));
            })
            .ForMember(dest => dest.Patient, opt => {
                opt.ResolveUsing(d => Mapper.Map<PatientDto>(d.patient));
            })
             .ForMember(dest => dest.constante, opt => {
                 opt.ResolveUsing(d => Mapper.Map<ConstanteDto>(d.constantes.FirstOrDefault()));
             })
           ;

            CreateMap<ConstanteRegisterDto, Constante>();
            CreateMap<Constante, ConstanteDto>()
            .ForMember(dest => dest.UserCreate, opt => {
                opt.ResolveUsing(d => d.utilisateur.personne.NomComplet);
            }).ForMember(dest => dest.Patient, opt => {
                opt.ResolveUsing(d => Mapper.Map<PatientDto>(d.patient));
            })
           ;


        }

    }
}
