The basic information extraction task is NE tagging [Krupka and Hausman 1998; Srihari et al.2000]. The NE tagger identifies and classifies proper names of type PERSON, ORGANIZATION, PRODUCT, NAMED-EVENTS, LOCATION (LOC) as well as numerical expressions such as MEASUREMENT (e.g.
A00-1034 M98-1015
Apply the ‘one sense per discourse’ principle [Gale et al.1992] for each disambiguated location name to propagate the selected sense to its other mentions within a document; Step 4.
H92-1045
Recent work emphasizes a corpus-based unsupervised approach [Dagon and Itai 1994; Yarowsky 1992; Yarowsky 1995] that avoids the need for costly truthed training data.
C92-2070 P95-1026
This problem was solved by developing a procedure to automatically extract default senses from web pages using the Yahoo! search engine [Li et al.2002]. Such a procedure has the advantage of enabling ‘re-training’ of default senses when necessary.
C02-1127
Event type: <Die: Event 200> Who: <Julian Werver Hill: PersonProfile 001> When: 1996-01-07 Where: <LocationProfile103> Preceding_event: <hospitalize: Event 260> Subsequent_event: <bury: Event 250> Event Visualization ; ; ; ; Predicate: Die Who: Julian Werner Hill When: Where: <LocationProfile 103> Hockessin, Delaware, USA, 19707,75.688873,39.77604 1996-01-07 Figure 2: Location-stamped Information Visualization 3 Previous Work and Issues This paper is follow-up research based on our previous work [Li et al.2002]. Some efficiency and performance issues are identified and addressed by the modified approach.
C02-1127
This involves two issues: (i) determining default senses using heuristics and/or other methods, such as statistical processing for semi-automatic default sense extraction from the web [Li et al.2002]; and (ii) setting the conditions/thresholds and the proper levels when assigning default senses, to coordinate with local and discourse evidence for enhanced performance.
C02-1127
Yarowsky. 1992.
C92-2070
Document Processor Knowledge Resources Lexicon Resources Grammars Process Manager Tokenlist Legend Output Manager Source Document Linguistic Processor(s)Tokenizer Tokenlist Lexicon Lookup POS Tagging NE Tagging Shallow Parsing Relationship Extraction Document pool NE CE EP SVO Time Normalization Profile/Event Consolidation Event Extraction Abbreviations NE = Named Entity CE = Correlated Entity EP = Entity Profile SVO = Subject-Verb-Object GE = General Event PE = Predefined Event Rule-based Pattern Matching Procedure or Statistical Model Hybrid Module GE Statistical Models PE IE Repository Deep Parsing Coreference Location Normalization Measurement Normalization Figure 1: System Architecture of InfoXtract InfoXtract combines the Maximum Entropy Model (MaxEnt) and Hidden Markov Model for NE tagging [Srihari et al.2000]. Maximum Entropy Models incorporate local contextual evidence to handle ambiguity of information from a location gazetteer.
A00-1034
Knowledge-based work, such as [Hirst 1987; McRoy 1992; Ng and Lee 1996] used hand-coded rules or supervised machine learning based on an annotated corpus to perform WSD.
J92-1001 P96-1006
The previous algorithm [Li et al.2002] for location normalization consisted of five steps.
C02-1127
