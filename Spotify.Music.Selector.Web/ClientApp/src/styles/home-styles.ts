import { createStyles, Theme } from '@material-ui/core';

const styles = ({ palette, spacing, breakpoints }: Theme) => createStyles({
    root: {
        
    },
    paper: {
      padding: 20
    },
    card: {
        maxWidth: 345,
        margin: 10
      },
      media: {
        height: 140,
      }
});

export default styles;