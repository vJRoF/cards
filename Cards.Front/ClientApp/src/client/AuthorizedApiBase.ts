/**
 * Configuration class needed in base class.
 * The config is provided to the API client at initialization time.
 * API clients inherit from #AuthorizedApiBase and provide the config.
 */
export class IConfig {
  /**
   * Returns a valid value for the Authorization header.
   * Used to dynamically inject the current auth header.
   */
  token: string;

  constructor(token: string) {
    this.token = token;
  }
}
  
export class AuthorizedApiBase {
  private readonly config: IConfig;

  protected constructor(config: IConfig) {
    this.config = config;
  }

  protected transformOptions = (options: RequestInit): Promise<RequestInit> => {
    options.headers = {
      ...options.headers,
      Authorization: this.config.token,
    };
    return Promise.resolve(options);
  };
}