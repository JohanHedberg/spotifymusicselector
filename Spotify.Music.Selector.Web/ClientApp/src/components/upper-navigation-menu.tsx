import * as React from 'react';
import Typography from '@material-ui/core/Typography';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Styles from '../styles/upper-navigation-menu-styles';
import { WithStyles } from '@material-ui/core/styles';
import ShareIcon from '@material-ui/icons/Share';

export interface UpperNavigationMenuProps extends WithStyles<typeof Styles> {

}

export interface UpperNavigationMenuDispatchProps {

}

export type Props = UpperNavigationMenuProps & UpperNavigationMenuDispatchProps;

const UpperNavigationMenu = (props: Props) => {
    const { classes } = props;

    return (
        <AppBar
            className={classes.root}
        >
            <Toolbar>
                <ShareIcon />
                <Typography
                    variant="h6"
                    className={classes.title}
                    noWrap
                >
                    Spotify Music Selector
                </Typography>
            </Toolbar>
        </AppBar>
    );
};

export default UpperNavigationMenu;