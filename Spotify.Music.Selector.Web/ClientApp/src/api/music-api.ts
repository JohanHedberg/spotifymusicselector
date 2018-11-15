import axios from 'axios';

class MusicApi {
    public static getRecommendations = async (
        baseApiUrl: string,
        genre?: string,
        artistId?: string
    ) => {
        const url = `${baseApiUrl}api/recommendations?genre=${genre}&artistId=${artistId}`;
        const response = await axios.get(url);

        return response.data;
    };

    public static getGenres = async (baseApiUrl: string) => {
        const url = `${baseApiUrl}api/genre`;
        const response = await axios.get(url);

        return response.data;
    };
}

export default MusicApi;