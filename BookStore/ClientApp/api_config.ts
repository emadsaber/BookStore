import { HttpMethod } from "@auth0/auth0-angular";
import { authConfig as authConf } from './auth_config';

export const apiConfig = {
  books: {
    edit: {
      uri: 'api/Books/EditBookDetails',
      httpMethod: HttpMethod.Post,
      tokenOptions: {
        audience: authConf.audience,
        scope: 'edit:bookdetails'
      }
    }
  },
  users: {
    createOrUpdate: {
      uri: 'api/Users/CreateOrUpdate',
      httpMethod: HttpMethod.Post
    },
    getUser: {
      uri: 'api/Users/GetUserByAuthUserId',
      httpMethod: HttpMethod.Post
    }
  }
}
