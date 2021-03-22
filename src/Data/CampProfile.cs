using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile 
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>()
                .ForMember(c => c.VenueName, o => o.MapFrom(m => m.Location.VenueName))
                .ForMember(d => d.Address1, e => e.MapFrom(f => f.Location.Address1))
                .ForMember(g => g.Address2, h => h.MapFrom(i => i.Location.Address2))
                .ForMember(j => j.Address3, k => k.MapFrom(l => l.Location.Address3))
                .ForMember(n => n.CityTown, p => p.MapFrom(q => q.Location.CityTown))
                .ForMember(r => r.StateProvince, s => s.MapFrom(t => t.Location.StateProvince))
                .ForMember(u => u.PostalCode, v => v.MapFrom(w => w.Location.PostalCode))
                .ForMember(x => x.Country, y => y.MapFrom(z => z.Location.Country))
                .ReverseMap();

            this.CreateMap<Talk, TalkModel>()
                .ReverseMap()
                .ForMember(t => t.Camp, opt => opt.Ignore())
                .ForMember(t => t.Speaker, opt => opt.Ignore());

            this.CreateMap<Speaker, SpeakerModel>()
                 .ReverseMap();
        }
        
    }
}
