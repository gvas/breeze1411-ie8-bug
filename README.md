Trying to download data with breeze 1.4.11 and IE8 throws the following exception:

Unable to either parse or import metadata: getters & setters can not be defined on this javascript engine

The error is caused by [line 173 of b00_breeze.modelLibrary.backingStore.js](https://github.com/IdeaBlade/Breeze/blob/master/Breeze.Client/Scripts/IBlade/b00_breeze.modelLibrary.backingStore.js#L173)