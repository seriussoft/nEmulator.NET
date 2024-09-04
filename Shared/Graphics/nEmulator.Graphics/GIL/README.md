# [GIL] Graphics IL

## IL can be interpreted in a few different ways...
Each interpretation or representation is relevant to the purpose of this GIL

1. Instructions can be interpreted...
1. Naturally, they should be instructional...
1. And, when put together, they form an intermediary instruction-set or language...

_Intermediary|Interpreted|Instructional Language_

For the intents of this specific niche project, which is generating a framework 
  through which one can draw things to a medium, we needed to develop a customizable|modular method
  to initiate a "printing" of Mapped-Bits to|through some medium.

## ToC [Table of Contents]
1. [Our General Graphics Engine Scope](#Our-General-Gfx-Engine-Scope)
1. [Our Options](#Our-Options)
    1. [Option A](#Option-A)
    1. [Option B](#Option-B)
    1. [Option C](#Option-C)
1. [Chosen Solution](#Chosen-Solution)
    1. [What do we need?](#What-Do-We-Need)
1. [Terminology - _Terms and Keywords_](#Terms-and-Keywords)


<a name="Our-General-Gfx-Engine-Scope"></a>
Be it
1. A Bitmap filestream (_Bitmaps are specifically on a 1:1 [or variant] colored-segment to pixel ratio_)
1. An on-screen Bitmap|Image|Virtual-Space
1. Directly printed to the screen
1. Or even printed to a physical medium such as through an inkjet|laser printer

<a name="Our-Options"></a>
We had a few options, but each come with their own boons &amp; drawbacks, benefits &amp; deficits, incentives &amp; deterrents...
1. [ ] **Generate an API that includes a set of interface-contracts through which one can register and/or utilize in-situ a specific Bitmap-Printing module(s).**
    1. **Think of this as:** your traditional model used in WebAPI and similar situations, but you would call into said API and you may or may not get feedback about the result of the API entry/operation...
    1. **Boons:** 
        1. [X] Fast to develop first prototype
        1. [X] This model is commonly used in Open-Src development, which can be good and bad, but familiarity to a model is a boon/benefit in the short-to-middle-term
        1. [ ]
        1. [ ]
    1. **Drawbacks:** 
        1. [ ] Slow-Final-Product(s): Each new engine will require more and more work to yield its fruit
        1. [X] Integration-Complexity: Integration seems generic but versioning across an API/WebAPI/SvcAPI is very difficult (branching functionality like when building a language that gets developed with features/fixes in multiple major version at a time [basic support issue])
        1. [X] The above issue turns into a headache for devs, QAs, consumers/users, consumer-devs, etc
        1. [X] Modularization-Difficulty: Modularization is difficult, which means that as new modules are developed, the product's success becomes tied directly with each implementation: it suffers for failures or inadequacies of each implementation directly, but but doesn't directly benefit from each successful implementation
        1. [X] Slow-Failure: If this model doesn't work for one of the 2 or 3 most necessary engines, then this can take a while to alert us to said problem, increase time it takes to research a solution, and may cause overall failure of the product long before we are aware of it.
1. [ ] **Generate a set of contracts that all bitmap-printing modules must adhere to,** but otherwise have relative freedom to go above/beyond the initial-expectation, or choose not to fulfil certain requirements so long as they don't break the general/overall skeleton-of-a-contract _(must pass visual/audible inspection, but could fail at runtime)_
    1. **This is akin to:** how I built SqlTools, tool for making swapping between SqlServer (MsSQL), MySQL, and engine-agnostic ANSI-SQL with little to no changes to your code. 
        1. It was insanely better than doing it from scratch each time and it simplified _(in ways I **cannot overrestimate**)_ database interop for any project where ERM or other Object-Model style Database-Interop were too much bloat, too dense, or otherwise inappropriate...
        1. It wasn't, however, a __'free'__ swap-in _(except for super simple projects where no database-specific techniques/code/functionality was utilized)_...
        1. You had to not only:
            1. change dependencies when swapping 
            1. (or include all dependencies for all options you may one-day use)
            1. be completely aware of the host environment (everything from versions, OS versions, whether your code would run in a silo'd or fully isolated environment, whether it was a website with full, medium, or low trust, how many open connections were allowed for every X minutes/hours/days, etc)
            1. and unless you stuck to features that were generally available no matter the database host-type, data-engine, and feature-set (even across versions of the same Database)
    1. **Boons:** 
        1. [X] Speed: Faster to Develop
        1. [X] CYOA: Unit-Testing was a valid option
        1. [X] CYOA: Integrated Testing was also a valid option
        1. [X] Consumer-Developer-Friendly: Others could use your existing interface-contracts and built-in options as a starting point for any other module they wanted to develop
        1. [X] Dependability/Customer-Trust: Because you had separate modules which depended upon a single baseline module, the system would function well to always provide a functional alternative if you weren't utilizing any of the company/product specific engines
    1. **Drawbacks:** 
        1. [ ] Maintenance becomes a chore
        1. [X] Anything added to one would eventually need added to all others or there could become a complex feature-tree (think Visual Studio from 2010 or before OR trying to serve compiled software with minimal setup or dependency hotel-expense-lists across all major and less-major Linux distros)
        1. [X] Certain features were very specific to DB Host-Type + DB Data-Engine + Environment + Versions of each
        1. [X] If you cannot have a central or general working module that works no matter the product used, you are hooked into a specific engine - no general "let's get this working in basic mode and add each module on after the fact so we aren't tied to any one company or product just to test it or use it"
        1. [X] This can cause trouble with serving a truly platform-agnostic product because there will be platforms where one of your main product dependencies just isn't available... 
1. [X] Create an interpreter to read some codes or instructions that can be recorded by any recorder and replayed by any interpreter. _Think about what made java so successful across its many embedded/isolated/general devices._
    1. **Boons:** 
        1. [X] Continuous development should produce new functionality at, at least, a linear or even geometric rate - once you have the initial framework/interpreter, then the more you have: the more there is to build-upon
        1. [X] Modularization is open to more than just entire modules, one can script or write code that improves on the featureset w/o the heavy burden of creating a new module. 
        1. [X] Improvements to efficiency (memory, number of operations, etc) can be made at 3 different places:
            1. [X] **In the IL Recorder(s)** - _(does the recorder record each instruction verbatum, does it do any mid-level or even in-situ adjustments/optimizations based on operational-data or Behavior-data's KB)_
            1. [X] **In the IL Interpreter(s)** - __
            1. [X] **In the IL's Playback Agent(s)** - __
            1. [X] **In the code utilizing the Recorders/Interpreters/Playback-Agents/etc** - __
        1. [X] New features can be added via additional IL opcodes, new Instructions, new Instruction-Sets, changes to the printing engines, optimizations to recorders/interpreters/playback-agents, addition of extra steps performed during the process of flushing the Bitmap data/operations to the medium(s) (such as Levels of Indirection)
        1. [X] The main Managers/Factories don't have to know a single thing about what these Graphics-Engines and Printing-Agents need, how they operate, what they do, do they even work, can you see the results, etc
        1. [X] The main Managers/Factories don't even have to know what medium is being manipulated, if there even is a medium, what is a medium, etc
        1. [X] [X] [X] Separation-of-Concerns: Vast Changes to the IL, Interpreters, Recorders, etc can be done in such a way as to maintain backwards compatibility while also not locking new engines/agents down to the old way of doing things (think about how C# has developed over the years both serial an parallel to .NET-Fwk|.NET-CORE, VB.NET, F#, Unmanaged-C++, Managed-C++, etc - and how the MSIL and CIL have changes that the C# language has no idea about)
        1. [X] [X] [X] IL can be developed independent of the Managers|Factories, the Agents (Recording, Interpreting, Playing-back, [de]Serialization), and Consumers
        1. [X] There's nothing stopping a service/daemon, CLI app, already open-and-watching-app, or other bit of software from handling GIL interpretation, recording, playing-back, etc - could be in another programming language altogether, a scripting tool, an algorithm dev'd by someone else, or even bit-by-bit by a human following instructions, line-by-line, as if they were putting together some Lego contraption or a piece of furniture from IKEA!
    1. **Drawbacks:** 
        1. [ ] Slow to develop first working prototype
        1. [X] More complex than just a simple Here's your Interface-Contract(s), now line up code to it, build it, test it, and publish it...
        1. [ ]
        1. [ ]

<a name="Chosen-Solution"></a>
### Chosen Solution - _Let's Build a GIL_ or G~raphics~I~ntermediary~L~anguage~

<a name="What-Do-We-Need"></a>
#### What Do We Need?

<a name="Terms-and-Keywords"></a>
### Terminology - Terms &amp; Keywords - ~_What are the keywords, what do they mean, and why do we need 'em?_~

  1. GIL, Graphics IL, IL
  1. Managers &amp; Factories
  1. SVG and Similarities
  1. Agents
      1. Recorders
      1. Readers
      1. Interpreters
      1. Playback
      1. ...
      1. ...
      1. ...
      1. ...
  1. Flush
  1. Brush vs Pen
  1. Path vs Area vs Region vs Shape
  1. Closed vs Open Line-Segments|Arcs|Curves|Splines
  1. ICodes or OpCodes
      1. Draw-__X__
          1. Draw-Point
          1. Draw-Line
          1. Draw-Arc | Draw-Curve
          1. Draw-Shape
          1. Draw-Area
          1. Draw-Image
          1. Draw-Sprite
          1. Draw-BG | Draw-Background
          1. Draw-Animation
          1. Draw-Layer
      1. Fill-__X__
          1. Fill-LineSegments --path might be more appropriate here...
          1. Fill-Spline
          1. Fill-BezierSpline
          1. Fill-CardinalSpline
          1. Fill-Path
          1. Fill-Shape
          1. Fill-Area
          1. Fill-Image
          1. Fill-Sprite
          1. Fill-BG | Fill-Background
          1. Fill-Layer
      1. ApplyTextureTo_X
          1. ApplyTextureToPath
          1. ApplyTextureToShape
          1. ApplyTextureToArea
          1. ApplyTextureToImage
          1. ApplyTextureToSprite
          1. ApplyTextureToBG | ApplyTextureToBackground
          1. ApplyTextureToLayer
          1. ApplyTextureToGradient
      1. ApplyGradientAlong-__X__
          1. ApplyGradientAlong-Line
          1. ApplyGradientAlong-Arc | ApplyGradientAlong-Curve
          1. ApplyGradientAlong-Spline
          1. ApplyGradientAlong-BezierSpline
          1. ApplyGradientAlong-CardinalSpline
          1. ApplyGradientAlong-Path
          1. ApplyGradientAlong-Shape
          1. ApplyGradientAlong-Area
          1. ApplyGradientAlong-Image
          1. ApplyGradientAlong-Sprite
          1. ApplyGradientAlong-BG | ApplyGradientAlong-Background
          1. ApplyGradientAlong-Layer
      1. Invert-__X__
          1. Invert-Point
          1. Invert-Line
          1. Invert-Arc | Invert-Curve
          1. Invert-Spline
          1. Invert-BezierSpline
          1. Invert-CardinalSpline
          1. Invert-Path
          1. Invert-Shape
          1. Invert-Area
          1. Invert-Image
          1. Invert-Sprite
          1. Invert-BG | Invert-Background
          1. Invert-Layer
          1. Invert-Gradient
      1. ChangeColorOf-__X__
          1. ChangeColorOf-Point
          1. ChangeColorOf-Line
          1. ChangeColorOf-Arc | ChangeColorOf-Curve
          1. ChangeColorOf-Spline
          1. ChangeColorOf-BezierSpline
          1. ChangeColorOf-CardinalSpline
          1. ChangeColorOf-Path
          1. ChangeColorOf-Shape
          1. ChangeColorOf-Area
          1. ChangeColorOf-Image
          1. ChangeColorOf-Sprite
          1. ChangeColorOf-BG | ChangeColorOf-Background
          1. ChangeColorOf-Layer
          1. ChangeColorOf-Gradient
      1. ChangeTransparency-__X__
          1. ChangeTransparency-Point
          1. ChangeTransparency-Line
          1. ChangeTransparency-LineSegments
          1. ChangeTransparency-Arc | ChangeTransparency-Curve
          1. ChangeTransparency-Spline
          1. ChangeTransparency-BezierSpline
          1. ChangeTransparency-CardinalSpline
          1. ChangeTransparency-Path
          1. ChangeTransparency-Shape
          1. ChangeTransparency-Area
          1. ChangeTransparency-Image
          1. ChangeTransparency-Sprite
          1. ChangeTransparency-BG | ChangeTransparency-Background
          1. ChangeTransparency-Layer
          1. ChangeTransparency-Gradient
          1. ChangeTransparency-???
  1. ...
  1. ...
  1. ...
  1. ...
  1. ...
  1. ...
  1. ...
  1. ...
  1. ...
  1. ...
  1. ...

<a name="Terms-IL"></a>
#### IL - _Intermediary|Interpreted|Instructional Language_


<a name="Terms-Agents"></a>
#### Agents - _The Things That Have Special Roles_


<a name="Terms-Managers-and-Factories"></a>
#### Managers &amp; Factories - _The Things That Run_


<a name="Terms-Interpreters"></a>
#### [Agent] Interpreters - _The Things That Interpret the IL_


<a name="Terms-Readers"></a>
#### [Agent] Readers - _The Things That Read the IL_


<a name="Terms-Recorders"></a>
#### [Agent] Recorders - _The Things That Record the IL_


<a name="Terms-Playback"></a>
#### [Agent] Playback - _The Things That Playback the IL or Instructions_


<a name="Terms-Flush"></a>
#### [Nomenclature] Flush - _To Flush is to Force Run of Unfinished Business_


<a name=""></a>
#### ???? - _The Things That ???_


<a name="Examples"></a>
### Examples - _The Things That ???_


<a name=""></a>
#### ???? - _The Things That ???_


<a name=""></a>
### ???? - _The Things That ???_




