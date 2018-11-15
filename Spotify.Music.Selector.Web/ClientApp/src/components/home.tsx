import * as React from 'react';
import Styles from '../styles/home-styles';
import { WithStyles } from '@material-ui/core/styles';
import Recommendations from './containers/recommendations';
import Questions from './containers/questions';

export interface HomeProps extends WithStyles<typeof Styles> {

}

export interface HomeDispatchProps {

}

export type Props = HomeProps & HomeDispatchProps;

const Home = (props: Props) => {
    const { classes } = props;

    return (
        <div
            className={classes.root}
        >
            <Questions />
            <Recommendations />
        </div>
    );
};

export default Home;