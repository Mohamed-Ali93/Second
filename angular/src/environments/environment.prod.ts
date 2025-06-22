import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44311/',
  redirectUri: baseUrl,
  clientId: 'Second_App',
  responseType: 'code',
  scope: 'offline_access Second',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Second',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44311',
      rootNamespace: 'Second',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
