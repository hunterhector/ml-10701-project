5The rules are actually represented as KB classes with appropriate basic-question, component, and task role fillers, and attached data that indicates the facts to be communicated; content-determination is done by classifying the current question-space point into the rule taxonomy, and inheriting the attached data \[Reiter and Mellish, 1992\].
C92-1038 P92-1034
• Discourse-in.focus: The set of in-focus objects for referring expression generation \[Grosz and Sidner, 1986\].
J86-3001
The current IDAS prototype does not do anything interesting in modeling the discourse structure of hypertext dialogues; it simply assumes that each hypertext node corresponds to a separate closed focus-space \[Grosz and Sidner, 1986\], and hence that an object introduced in one node cannot be referred to in another node unless it is re-introduced.
J86-3001
Instead of using planning \[Moore and Paris, 1989\] or schemas \[McKeown, 1985\] to determine what to communicate, IDAS's contentdetermination system is based on rules (created by domain experts) of the form 'if a user asks question Q about a component of type C in the context of task T, he should be told facts F'.
P89-1025
Many of the theoretically interesting aspects of IDAS' KR and NLG systems are discussed elsewhere, e.g., \[Re iter and Mellish, 1992; Reiter and Dale, 1992\].
C92-1038 P92-1034
The question space point is given to IDAS's NL generation system, which generates a response using three modules: content determination, which picks relevant information out of the knowledge base to communicate to the user; text planning, which converts this information into an expression in SPL, the ISI Sentence Planning Language \[Kasper, 1989\]; and surface realization, which produces a surface form, i.e., an annotated text string.
H89-1022
