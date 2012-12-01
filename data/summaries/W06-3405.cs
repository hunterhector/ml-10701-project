But if the utterances related to these properties form distinct sub-classes which have their own distinct features, treating them separately and combining the results (along the lines of (Klein et al., 2002)) might allow better performance, while also identifying the utterances where each property’s value is extracted.
W02-0811
While there are related tags for dialogue act tagging schema – like DAMSL (Core and Allen, 1997), which includes tags such as Action-Directive and Commit, and the ICSI MRDA schema (Shriberg et al., 2004) which includes a commit tag – these classes are too general to allow identification of action items specifically.
W04-2319
Like (Corston-Oliver et al., 2004) we used support vector machines (Vapnik, 1995) via the classifier SVMlight (Joachims, 1999).
W04-1008
Finally, we are developing an interface to a new large-vocabulary version of the Gemini parser (Dowding et al., 1993) which will allow us to use semantic parse informationasfeaturesintheindividualsub-classclassifiers, and also to extract entity and event representations from the classified utterances for automatic addition of entries to calendars and to-do lists.
P93-1008
Related Work Corston-Oliver et al.(2004) attempted to identify action items in e-mails, using classifiers trained on annotations of individual sentences within each e-mail.
W04-1008
We are actively investigatingalternativeapproachestosub-classifiercombination: better performance (and a more robust and trainable overall system) might be obtained by using a Bayesian network, or a maximum entropy classifier as used by (Klein et al., 2002).
W02-0811
