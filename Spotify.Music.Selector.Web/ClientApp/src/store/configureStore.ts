import { applyMiddleware, compose, createStore } from 'redux';
import thunk from 'redux-thunk';
import RootReducer from '../reducers/root-reducer';
import StoreState from '../state/index';

declare global {
  interface Window {
    __REDUX_DEVTOOLS_EXTENSION_COMPOSE__: any;
    devToolsExtension: any;
    store: any;
  }
}

export default function configureStore(history: any, initialState: StoreState) {
  
  const middleware = [
    thunk
  ];

  const enhancers = [];
  const isDevelopment = process.env.NODE_ENV === 'development';

  if (isDevelopment && typeof window !== 'undefined' && window.devToolsExtension) {
    enhancers.push(window.devToolsExtension());
  }

  return createStore(
    RootReducer,
    initialState,
    compose(applyMiddleware(...middleware), ...enhancers)
  );
}