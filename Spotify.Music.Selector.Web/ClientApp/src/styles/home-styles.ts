import { createStyles, Theme } from '@material-ui/core';

const styles = ({ palette, spacing, breakpoints }: Theme) => createStyles({
  root: {
    marginTop: 20,
    marginLeft: 'auto',
    marginRight: 'auto'
  },
  paper: {
    padding: 20,
    maxWidth: 700,
    textAlign: 'center'
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