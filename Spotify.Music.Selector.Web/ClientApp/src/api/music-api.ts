import axios from 'axios';

class MusicApi {
    public static getRecommendations = async (baseApiUrl: string) => {
        const url = `${baseApiUrl}/api/recommendations`;
        const response = await axios.get(url);

        return response.data;
    };
}

export default MusicApi;