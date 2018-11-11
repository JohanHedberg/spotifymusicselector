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
        <div className={classes.root}>
            <Paper
                square
                className={classes.paper}
            >
                <Typography variant="h3" gutterBottom>
                    Who's your favorite?
                  </Typography>
                <Grid 
                    container
                    spacing={24}
                >
                    <Grid item xs={6}>
                        <Card
                            square
                        >
                            <CardActionArea>
                                <CardMedia
                                    className={classes.media}
                                    image={props.recommendations[0].img}
                                    title={props.recommendations[0].name}
                                />
                                <CardContent>
                                    <Typography 
                                        variant="body2" 
                                        gutterBottom
                                    >
                                        {props.recommendations[0].artist}
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
                                    image={props.recommendations[0].img}
                                    title={props.recommendations[0].name}
                                />
                                <CardContent>
                                    <Typography
                                        variant="body2" 
                                        gutterBottom
                                    >
                                        {props.recommendations[0].artist}
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
                    justify="space-between"
                >
                    {props.recommendations.map((item, index: number) => (
                        <Grid item key={index}>
                            <Card className={classes.card} square>
                                <CardActionArea>
                                    <CardMedia
                                        className={classes.media}
                                        image={item.img}
                                        title={item.name}
                                    />
                                    <CardContent>
                                        <Typography variant="body2" gutterBottom>{item.artist}</Typography>
                                        <Typography variant="body1">{item.name}</Typography>
                                    </CardContent>
                                </CardActionArea>
                            </Card>
                        </Grid>
                    ))}
                </Grid>
            </Paper>
        </div>
    );
};

export default Home;