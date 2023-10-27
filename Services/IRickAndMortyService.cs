using MauiAppBlazor.Models;

namespace MauiAppBlazor.Services;

public interface IRickAndMortyService
{
    public Task<RickAndMorty> Get();
}
