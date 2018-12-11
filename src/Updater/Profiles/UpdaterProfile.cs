using System;
using AutoMapper;
using Schemas;
using Updater.Entities;

namespace Updater.Profiles
{
    public class UpdaterProfile : Profile
    {
        public UpdaterProfile()
        {
            CreateMap<artiklarArtikel, Product>()
                .ForMember(dest => dest.Alcohol, opt => opt.MapFrom(src => src.Alkoholhalt))
                .ForMember(dest => dest.Assortment, opt => opt.MapFrom(src => src.Sortiment))
                .ForMember(dest => dest.Discontinued, opt => opt.MapFrom(src => src.Utgått.Equals("1")))
                .ForMember(dest => dest.Ecological, opt => opt.MapFrom(src => src.Ekologisk.Equals("1")))
                .ForMember(dest => dest.Ethically, opt => opt.MapFrom(src => src.Etiskt.Equals("1")))
                .ForMember(dest => dest.Koscher, opt => opt.MapFrom(src => src.Koscher.Equals("1")))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Namn))
                .ForMember(dest => dest.Name2, opt => opt.MapFrom(src => src.Namn2))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.nr))
                .ForMember(dest => dest.Origin, opt => opt.MapFrom(src => src.Ursprung))
                .ForMember(dest => dest.Packaging, opt => opt.MapFrom(src => src.Forpackning))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => decimal.Parse(src.Prisinklmoms)))
                .ForMember(dest => dest.Producer, opt => opt.MapFrom(src => src.Producent))
                .ForMember(dest => dest.Seal, opt => opt.MapFrom(src => src.Forslutning))
                .ForMember(dest => dest.Size, opt => opt.MapFrom(src => decimal.Parse(src.Volymiml)))
                .ForMember(dest => dest.Style, opt => opt.MapFrom(src => src.Stil))
                .ForMember(dest => dest.Supplier, opt => opt.MapFrom(src => src.Leverantor))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Typ))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => string.IsNullOrWhiteSpace(src.Argang) ? 0 : Convert.ToInt32(src.Argang)))
                .ForMember(dest => dest.AssortmentText, opt => opt.MapFrom(src => src.SortimentText))
                .ForMember(dest => dest.ProductGroup, opt => opt.MapFrom(src => src.Varugrupp))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => Convert.ToInt32(src.Artikelid)))
                .ForMember(dest => dest.ProductNumber, opt => opt.MapFrom(src => Convert.ToInt32(src.Varnummer)))
                .ForMember(dest => dest.YearTested, opt => opt.MapFrom(src => string.IsNullOrWhiteSpace(src.Provadargang) ? 0 : Convert.ToInt32(src.Provadargang)))
                .ForMember(dest => dest.CountryOfOrigin, opt => opt.MapFrom(src => src.Ursprunglandnamn))
                .ForMember(dest => dest.PricePerLitre, opt => opt.MapFrom(src => decimal.Parse(src.PrisPerLiter)))
                .ForMember(dest => dest.RawMaterialDescription, opt => opt.MapFrom(src => src.RavarorBeskrivning))
                .ForMember(dest => dest.StartOfSale, opt => opt.MapFrom(src => DateTime.Parse(src.Saljstart)));

            CreateMap<ButikerOmbudButikOmbud, Store>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address4))
                .ForMember(dest => dest.County, opt => opt.MapFrom(src => src.Address5))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Namn))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Nr))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Telefon))
                ;
        }
    }
}