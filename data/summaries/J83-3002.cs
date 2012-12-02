Related Work The parsing approach closest in spirit to our fitting procedure is that described in Slocum (1983, p.
A83-1028
Kwasny and Sondheimer (1981) are strong proponents of relaxation techniques, which they use to handle both cases of clearly ungrammatical structures, such as co-occurrence violations like subject/verb disagreement, and cases of perfectly acceptable but difficult constructions (ellipsis and conjunction).
J81-2002
Weischedel, R.M. and Sondheimer, N.K. 1982 An Improved Heuristic for Ellipsis Processing.
P82-1016
(See Heidorn et al.(1982) for a more thorough discussion of the error correction technique).
P82-1015
Details of the EPISTLE system and of its core grammar may be found in Heidorn et al.(1982). An earlier overview of the system is presented in Miller et al.(1981). A close examination of parse trees produced by the core grammar will often reveal branch attachments that are not quite right: for example, semantically incongruous prepositional phrase attachments.
P82-1015
Weischedel and Sondheimer (1982) describe an improved ellipsis processor.
P82-1016
This is undoubtedly a useful strategy one which EPISTLE makes use of, in fact, in its rules for detecting grammatical errors (Heidorn et al.1982). However, it is questionable whether such a strategy can ultimately succeed in the face of the overwhelming (for all practical purposes, infinite) variety of ill-formedness with which we are faced when we set out to parse truly unrestricted natural language input.
P82-1015
Weischedel, R.M. and Black, J.E. 1980 Responding Intelligently to Unparsable Inputs.
J80-2003
Hayes and Mouradian (1981) also use the relaxation method.
J81-4002
Kwasny, S.C. and Sondheimer, N.K. 1981 Relaxation Techniques for Parsing Ill-Formed Input.
J81-2002
Ravin Parse Fitting and Prose Fixing In EPISTLE, (a) the core grammar consists at present of a set of about 300 syntax rules; (b) ambiguity is resolved by using a metric that ranks alternative parses (Heidorn 1982); and (c) parse failure is handled by the fitting procedure described here.
P82-1015
Heidorn, G.E. 1982 Experience with an Easily Computed Metric for Ranking Alternative Parses.
P82-1015
Ravin Parse Fitting and Prose Fixing References Hayes, P.J. and Mouradian, G.V. 1981 Flexible Parsing.
J81-4002
Thus Weischedel and Black (1980) suggest three techniques for responding intelligently to unparsable inputs: (a) using presuppositions to determine user assumptions; this course is not available to a syntactic grammar like EPISTLE's; (b) using relaxation techniques; (c) supplying the user with information about the point where the parse is blocked; this would require an interactive environment, which would not be possible for every type of natural language processing application.
J80-2003
Access to an on-line standard dictionary with about 130,000 entries, including part-of-speech and some other syntactic information (such as transitivity of 1 The work described here is a continuation of work first presented at the Conference on Applied Natural Language Processing in Santa Monica, California (Jensen and Heidorn 1983).
A83-1015
