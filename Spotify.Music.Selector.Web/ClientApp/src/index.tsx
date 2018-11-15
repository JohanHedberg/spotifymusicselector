import * as React from 'react';
import * as ReactDOM from 'react-dom';
import { Provider } from 'react-redux';
import { createBrowserHistory } from 'history';
import { MuiThemeProvider, createMuiTheme } from '@material-ui/core/styles';
import CssBaseline from '@material-ui/core/CssBaseline';
import configureStore from './store/configureStore';
import { InitialState } from './state/index';
import App from './components/containers/app';
import registerServiceWorker from './registerServiceWorker';
import { BrowserRouter } from 'react-router-dom';
import MusicApi from '../src/api/music-api';
import * as Actions from './actions/application-actions';

const theme = createMuiTheme({
  palette: {
    primary: {
      main: '#263238',
      light: '#4f5b62',
      dark: '#000a12'
    },
    secondary: {
      main: '#8ac148',
      light: '#bdf478',
      dark: '#599014'
    }
  },
  typography: {
    useNextVariants: true
  }
});

// Create browser history to use in the Redux store.
const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const history = createBrowserHistory({ basename: baseUrl! });

// Get the application-wide store instance, prepopulating with state from the server where available.
const store = configureStore(history, InitialState);

const rootElement = document.getElementById('root');

MusicApi.getRecommendations('./').then(
  (recommendations) => store.dispatch(Actions.setRecommendations(recommendations))
);

ReactDOM.render(
  <Provider store={store}>
    <MuiThemeProvider theme={theme}>
      <CssBaseline />
      <BrowserRouter>
        <App />
      </BrowserRouter>
    </MuiThemeProvider>
  </Provider>,
  rootElement);

registerServiceWorker();