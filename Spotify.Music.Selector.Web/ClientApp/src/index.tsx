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
      main: '#01579b'
    },
    secondary: {
      main: '#ff8f00'
    }
  },
  typography: {

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