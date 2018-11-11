import TrackData from '../types/track';

export interface ApplicationState {
    mainMenuIsVisible: boolean;
    notificationBarIsVisible: boolean;
    notificationMessage: string;
    recommendations: Array<TrackData>;
}

export interface StoreState {
    application: ApplicationState;
}

export const InitialState: StoreState = {
    application: {
        mainMenuIsVisible: true,
        notificationBarIsVisible: false,
        notificationMessage: '',
        recommendations: [{
            name: 'Smells Like Teen Spirit',
            artist: 'Nirvana',
            img: 'https://is3-ssl.mzstatic.com/image/thumb/Features/d0/cc/62/dj.nanioukp.jpg/1200x630bb.jpg'
        },
        {
            name: 'Smells Like Teen Spirit',
            artist: 'Nirvana',
            img: 'https://is3-ssl.mzstatic.com/image/thumb/Features/d0/cc/62/dj.nanioukp.jpg/1200x630bb.jpg'
        },
        {
            name: 'Smells Like Teen Spirit',
            artist: 'Nirvana',
            img: 'https://is3-ssl.mzstatic.com/image/thumb/Features/d0/cc/62/dj.nanioukp.jpg/1200x630bb.jpg'
        },
        {
            name: 'Smells Like Teen Spirit',
            artist: 'Nirvana',
            img: 'https://is3-ssl.mzstatic.com/image/thumb/Features/d0/cc/62/dj.nanioukp.jpg/1200x630bb.jpg'
        },
        {
            name: 'Smells Like Teen Spirit',
            artist: 'Nirvana',
            img: 'https://is3-ssl.mzstatic.com/image/thumb/Features/d0/cc/62/dj.nanioukp.jpg/1200x630bb.jpg'
        },
        {
            name: 'Smells Like Teen Spirit',
            artist: 'Nirvana',
            img: 'https://is3-ssl.mzstatic.com/image/thumb/Features/d0/cc/62/dj.nanioukp.jpg/1200x630bb.jpg'
        },
        {
            name: 'Smells Like Teen Spirit',
            artist: 'Nirvana',
            img: 'https://is3-ssl.mzstatic.com/image/thumb/Features/d0/cc/62/dj.nanioukp.jpg/1200x630bb.jpg'
        }]
    }
};

export default StoreState;