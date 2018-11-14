import ArtistData from './artist';
import AlbumData from './album';

interface Track {
    name: string;
    id: string;
    album: AlbumData;
    artists: Array<ArtistData>;
    markets: Array<string>;
}

export default Track;