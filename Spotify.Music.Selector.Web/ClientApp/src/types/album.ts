import ArtistData from './artist';
import ImageData from './image';

interface Album {
    name: string;
    id: string;
    images: Array<ImageData>;
    artists: Array<ArtistData>;
    genres: Array<string>;
}

export default Album;