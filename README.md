# Samples.Configuration
.NET Core sample project demonstrating Configuration

View the presentation slides [here](NET%20Fundamentals%20-%20Configuration.pdf).

---

### Information

The Config Providers link will display all of the registered configuraiton providers in order.

The Read All Configuration link will display all of the configuration values available to the application.

Two lab exercises are included.

---

### Default Provider Order

CreateDefaultBuilder in Program.cs provides default configuration (ordered):
- ChainedConfigurationProvider (also adds IConfiguration to dependency injection)
- appsetting.json (if exists)
- appsettting.\{*environment*\}.json – if environment is not set, Production is assumed. 
- App/User Secrets (secrets.json) - only used locally when environment is set to Development.
- Environment variables (provider)
- Command-line arguments (provider)

The default configuration providers (and order) can be overriden and additional providers can be added.

---

For more information, visit [Microsoft Docs - Configuration](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/)

[![YouTube](https://bradthecoder.github.io/images/social/Youtube_32x32.png)](https://www.youtube.com/channel/UCTuzKuNSTcGibER64p-SGxA) 
[![Twitter](https://bradthecoder.github.io/images/social/Twitter_32x32.png)](https://twitter.com/bradthecoder) 
[![Linkedin](https://bradthecoder.github.io/images/social/Linkedin_32x32.png)](https://www.linkedin.com/in/bradthecoder/)
[![www](https://bradthecoder.github.io/images/social/brad-the-coder_32x32.png)](https://bradthecoder.github.io/)
