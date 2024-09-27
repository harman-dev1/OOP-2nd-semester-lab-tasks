#include<iostream>
using namespace std;
class Anime
{
    public:
    string animeName;
    int animeEpisodes;
    void printAnimeName();
    void printAnimeEpisode()
    {
        cout << "Anime Episodes :" << animeEpisodes;
    }
};
void Anime::printAnimeName()
    {
        cout << "Anime Name :" + animeName << "\n";
    }
main()
{
    Anime a1;
    a1.animeName = "Naruto";
    a1.animeEpisodes = 720;
    a1.printAnimeName();
    a1.printAnimeEpisode();
}