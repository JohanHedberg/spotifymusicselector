import * as React from 'react';
import Home from './containers/home';
import { Route } from 'react-router-dom';
import UpperMenu from './containers/upper-navigation-menu';
import Styles from '../styles/app-styles';
import { WithStyles } from '@material-ui/core/styles';

export interface AppProps extends WithStyles<typeof Styles> {
  
}

export interface AppDispatchProps {

}

export type Props = AppProps & AppDispatchProps;

const App = (props: Props) => {
  const { classes } = props;

  return (
    <div className={classes.root}>
      <UpperMenu />
      <div className={classes.contentArea}>
        <Route exact={true} path="/" component={Home} />
      </div>
    </div>
  );
};

export default App;