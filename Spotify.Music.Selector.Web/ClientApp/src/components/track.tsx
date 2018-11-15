import * as React from 'react';
import Typography from '@material-ui/core/Typography';
import Styles from '../styles/track-styles';
import { WithStyles } from '@material-ui/core/styles';
import TrackData from '../types/track';
import Grid from '@material-ui/core/Grid';
import Card from '@material-ui/core/Card';
import CardMedia from '@material-ui/core/CardMedia';
import { CardContent, CardActionArea } from '@material-ui/core';

export interface TrackProps extends WithStyles<typeof Styles> {
    track: TrackData;
}

export interface TrackDispatchProps {

}

export type Props = TrackProps & TrackDispatchProps;

const Track = (props: Props) => {
    const { classes } = props;

    return (
        <Grid item>
        <Card className={classes.card} square>
            <CardActionArea>
                <CardMedia
                    className={classes.media}
                    image={props.track.album.images[0].url}
                    title={props.track.name}
                />
                <CardContent>
                    <Typography
                        variant="body2"
                        gutterBottom
                    >
                        {props.track.album.name}
                    </Typography>
                    <Typography
                        variant="body1"
                    >
                        {props.track.name}
                    </Typography>
                </CardContent>
            </CardActionArea>
        </Card>
    </Grid>
    );
};

export default Track;