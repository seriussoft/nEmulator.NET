Yes, I know that, for the most part, Megadrive and Genesis are cut from the same cloth.
However, I _also_ know that there were slightly different things going on in both.
  A. From a language/translation perspective
  B. Their [genesis vs megadrive] differences in birth
  C. Because they began handling  the "everyone experiences the same moment at once, 
  but because of timezones and other things, selling
  a game in one country vs another, as well as these countries vs those countries [think embargos, etc] - all 3 of these
  issues will be referred to at "the TZ problem" hereafter [within the subsequent sub-items of this item]...
      1. One solution to the _TZ problem_ required a different localization checker built into hardware and cartridge...
      2. Another solution to _the TZ problem_ was capable of being handled with only a hardware change (console unit) but
      having a software/ROM change in the cartridge...
      2. Yet another solution to _the TZ problem_ could be solved with a software/ROM change in the cartridge and 
      a software/ROM/BIOS change in the hardware...

To manage the last bullet point, _the TZ problem_, among others, we'll start with a general Genesis project (or projects)
  from within `$root\Sega\Genesis\`.
  A. If there are minimal problems faced that can be modified as a mere build change
  (i.e. small enough changes that can be added to a build-variable/build-flag/compiler-directive based logic OR
  the changes can be isolated to a small 1-tier or 2-tier compiler-flag [ _think compilation based config files, with
  one config being `nEmulator.Sega.Genesis.app.config` and another being `nEmulator.Sega.Genesis.Megadrive.app.config`_ ] ):
      1. Then, we won't even _"NEED"_ the Megadrive directory for a full project, just for the differences...
  A. If there are enough issues with changes such that the above solution, ALONE, just isn't tangible, maintainable, or even realistic:
      2. Then, we will try to put Megadrive-specific code into a separate project we place within the the main project's ( `$root\Sega\Genesis\` ) sibling directory: ( `$root\Sega\Megadrive\` ), and utilize 
  one, _or more_, of the steps mentioned in the previous item-entry above to load said changes, aiming to be read-in at build-time only, if at all possible...
  A. If that is still too unrealistic/convuluted/hard-to-maintain, then we will go the last available route:
      1. Compose a sibling project: `nEmulator.Sega.Genesis.Megadrive.csproj` that will live within `$root\Sega\Megadrive\` ...
      2. Extract AS MUCH AS POSSIBLE shared code between the two projects ( `nEmulator.Sega.Genesis.Genesis.csproj` and `nEmulator.Sega.Genesis.Megadrive.csproj` ),
      make it act as parent-code, or the base-classes, data-models, and more - then leaving both of the children projects to rely
      on this new csproj as a compilation-dependency.
      3. We feel that doing it this way will have a better outcome than making 2 separate csproj files that are code-copies (less copy-paste code-fixes and less sneaky-dependencies)
      both:
          3.1. BECAUSE it's cleaner/easier to see where the differences are (and where/why/how they actually matter)
          3.2. AND, it limits code-changes to less places...
          3.2.a For the most part, a problem with the Sega Genesis emulator _SHOULD_ only occur in the Megadrive, as well, _IF_ the bug/issue/defect occurs in the now base/parent project _(and vis-a-versa)_.
          3.2.b. Likewise, individual issues should only surface in their own individual projects, unless the way they pull from the parent project is somehow so different that it provokes such an issue...
