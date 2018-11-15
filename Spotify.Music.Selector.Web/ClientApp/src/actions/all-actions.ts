import { ApplicationAction } from './application-actions';
import { QuestionsAction } from './questions-actions';

type AllActions = ApplicationAction | QuestionsAction;

export default AllActions;