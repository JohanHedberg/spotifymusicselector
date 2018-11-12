import { createStyles, Theme } from '@material-ui/core';

const styles = ({ palette, spacing, breakpoints }: Theme) => createStyles({
    root: {
        backgroundColor: '#ededed'
    },
    contentArea: {
        marginTop: 56,
        padding: 20
    }
});

export default styles;