using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
