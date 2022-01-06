<!--bl
(filemeta
    (title "Setting up Gittey"))
/bl-->

Gittey is heavily part of the ecosystem of these exercises so it is impoatant to have Gittey configured correctly.

### Gittey Config File

It is worth reading the [Gittey documentation](https://github.com/cmstead/gittey/blob/main/README.md) as this document will only discuss the parts that pertain directly to what is needed for exercises.

There need to be a number aliases defined for Gittey, but most of these can be copied from any other Gittey config.

- test
  - This will be different in your exercise as it will run what ever command is used to test the code. It needs to start with ```cls;``` followed by your command and then it then needs to have ```&& gittey commit``` appended to the end of it.
- check
  - Again this one will be different. It needs to start with ```cls;``` followed by your test command.
- undo
  - Copy this command as it is the same no matter what.
- docs
  - Copy this command as it is the same no matter what.
- setup
  - This command will be different for each exercise. Its intent is to setup the directory for work with the assumption that any requirements are already installed on a machine. It should start with ```cls;``` followed by whatever command is needed to setup the directory.
- shrink
  - this will be different depending on exercise. This command removes any objects that are not user code. The idea is to make the directory small enough to be shared by a zip or other file archiving application.