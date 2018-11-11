import * as React from 'react';
import Typography from '@material-ui/core/Typography';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Styles from '../styles/upper-navigation-menu-styles';
import { WithStyles } from '@material-ui/core/styles';

export interface UpperNavigationMenuProps extends WithStyles<typeof Styles> {

}

export interface UpperNavigationMenuDispatchProps {

}

export type Props = UpperNavigationMenuProps & UpperNavigationMenuDispatchProps;

const UpperNavigationMenu = (props: Props) => {
    const { classes } = props;

    return (
        <AppBar
            color="primary"
            className={classes.root}
        >
            <Toolbar>
                <Typography
                    variant="title"
                    color="inherit"
                    style={{ flex: 1 }}
                    noWrap
                >
                    Spotify Music Selector
                </Typography>
            </Toolbar>
        </AppBar>
    );
};

export default UpperNavigationMenu;