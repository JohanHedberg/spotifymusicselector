import * as React from 'react';
import Typography from '@material-ui/core/Typography';
import Styles from '../styles/home-styles';
import { WithStyles } from '@material-ui/core/styles';
import TrackData from '../types/track';
import Grid from '@material-ui/core/Grid';
import Card from '@material-ui/core/Card';
import CardMedia from '@material-ui/core/CardMedia';
import { CardContent, CardActionArea } from '@material-ui/core';
import Paper from '@material-ui/core/Paper';
export interface HomeProps extends WithStyles<typeof Styles> {
    recommendations: Array<TrackData>;
}

export interface HomeDispatchProps {

}

export type Props = HomeProps & HomeDispatchProps;

const Home = (props: Props) => {
    const { classes } = props;

    return (
        <Grid
            className={classes.root}
            container
            justify="center"
        >
            <Grid item>

                <Paper
                    square
                    className={classes.paper}
                >
                    <Typography variant="h3" gutterBottom>
                        Who's your favorite?
                  </Typography>
                    {props.recommendations.length > 1 ?
                        <Grid
                            container
                            spacing={16}
                        >
                            <Grid item xs={6}>
                                <Card
                                    square
                                >
                                    <CardActionArea>
                                        <CardMedia
                                            className={classes.media}
                                            image={props.recommendations[0].album.images[0].url}
                                            title={props.recommendations[0].name}
                                        />
                                        <CardContent>
                                            <Typography
                                                variant="body2"
                                                gutterBottom
                                            >
                                                {props.recommendations[0].album.name}
                                            </Typography>
                                            <Typography
                                                variant="body1"
                                            >
                                                {props.recommendations[0].name}
                                            </Typography>
                                        </CardContent>
                                    </CardActionArea>
                                </Card>
                            </Grid>
                            <Grid item xs={6}>
                                <Card
                                    square
                                >
                                    <CardActionArea>
                                        <CardMedia
                                            className={classes.media}
                                            image={props.recommendations[1].album.images[0].url}
                                            title={props.recommendations[1].name}
                                        />
                                        <CardContent>
                                            <Typography
                                                variant="body2"
                                                gutterBottom
                                            >
                                                {props.recommendations[0].album.name}
                                            </Typography>
                                            <Typography
                                                variant="body1"
                                            >
                                                {props.recommendations[0].name}
                                            </Typography>
                                        </CardContent>
                                    </CardActionArea>
                                </Card>
                            </Grid>
                        </Grid>
                        : null}
                </Paper>
                <Paper
                    square
                    className={classes.paper}
                >
                    <Typography variant="h3" gutterBottom>
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
                            <Grid item key={index}>
                                <Card className={classes.card} square>
                                    <CardActionArea>
                                        <CardMedia
                                            className={classes.media}
                                            image={track.album.images[0].url}
                                            title={track.name}
                                        />
                                        <CardContent>
                                            <Typography
                                                variant="body2"
                                                gutterBottom
                                            >
                                                {track.album.name}
                                            </Typography>
                                            <Typography
                                                variant="body1"
                                            >
                                                {track.name}
                                            </Typography>
                                        </CardContent>
                                    </CardActionArea>
                                </Card>
                            </Grid>
                        ))}
                    </Grid>
                </Paper>
            </Grid>
        </Grid>
    );
};

export default Home;