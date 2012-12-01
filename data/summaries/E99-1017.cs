In the following section, we initially concentrate on the simple Case in (1) and show how (1) may be compiled assuming left-to-right processing along with the overall longest match strategy described by Karttunen (1996).
P96-1015
Improvements and extensions to this algorithm have been provided by Karttunen (1995), Karttunen (1997), Karttunen (1996) and Mohri and Sproat (1996).
P95-1003 P96-1015 P96-1031
Before describing the algorithm, it will be helpful to have at our disposal a few general tools, most of which were described already in Kaplan and Kay (1994).
J94-3001
The names of these steps are mostly derived from Karttunen (1995) and Mohri and Sproat (1996) even though the transductions involved are not exactly the same.
P95-1003 P96-1015 P96-1031
This functionality has been used in van Noord and Gerdemann (1999) to provide an implementation of the algorithm in Mohri and Sproat (1996).
P96-1031
of Markers Previous algorithms for compiling rewrite rules into transducers have followed Kaplan and Kay (1994) by introducing special marker symbols (markers) into strings in order to mark off candidate regions for replacement.
J94-3001
An algorithm for compilation into transducers was provided by Kaplan and Kay (1994).
J94-3001
Backreferencing has been implicit in previous research, such as in the "batch rules" of Kaplan and Kay (1994), bracketing transducers for finite-state parsing (Karttunen, 1996), and the "LocalExtension" operation of Roche and Schabes (1995).
J94-3001 J95-2004 P95-1003 P96-1015
For NLP finite state calculi (Karttunen et al., 1996; van Noord, 1997) this is unacceptable.
P96-1015
often cited advantage of finite state 5An anonymous reviewer suggested theft lm_concat could be implemented in the framework of Karttunen (1996) as: \[toltoplolpolo\]-+...
P96-1015
This problem was recognized by Karttunen (1996), whose algorithm starts with a filter transducer which filters out any string containing a marker.
P96-1015
The major components of the algorithm are not new, but straightforward modifications of components presented in Karttunen (1996) and Mohri and Sproat (1996).
P96-1015 P96-1031
6The bracketing operator of Karttunen (1996), on the other hand, does not provide for left and right contexts.
P96-1015
