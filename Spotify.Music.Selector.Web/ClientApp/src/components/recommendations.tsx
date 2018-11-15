import * as React from 'react';
import Typography from '@material-ui/core/Typography';
import Styles from '../styles/recommendations-styles';
import { WithStyles } from '@material-ui/core/styles';
import TrackData from '../types/track';
import Track from './containers/track';
import Grid from '@material-ui/core/Grid';
import Paper from '@material-ui/core/Paper';

export interface RecommendationsProps extends WithStyles<typeof Styles> {
    recommendations: Array<TrackData>;
}

export interface RecommendationsDispatchProps {

}

export type Props = RecommendationsProps & RecommendationsDispatchProps;

const Recommendations = (props: Props) => {
    const { classes } = props;

    return (
        <Paper
            square
            className={classes.paper}
        >
            <Typography variant="h4" gutterBottom>
                Recommended Tracks
        </Typography>
            <Typography variant="body1">
                Based on your previous anwsers, here's some recommendations on tracks
                that might suit you well.
        </Typography>
            <Grid
                container
                spacing={16}
            >
                {props.recommendations.map((track, index: number) => (
                    <Track track={track} key={index} />
                ))}
            </Grid>
        </Paper>
    );
};

export default Recommendations;