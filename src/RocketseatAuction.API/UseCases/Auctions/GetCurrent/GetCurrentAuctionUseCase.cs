using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Repositories;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repositorie = new RocketseatAuctionDbContext();

        return repositorie
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault();
    }
}
