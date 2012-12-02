However, the next step would be to find a relation that holds among 5 This is discussed in more detail in Bouayad-Agha, Power, and Scott (2000) and Bouayad-Agha (2001) and in section 5.3. 221 Power, Scott, and Bouayad-Agha Document Structure PARAGRAPH TEXT−SENTENCE TEXT−PHRASETEXT−PHRASE TEXT−PHRASE TEXT−PHRASE TEXT−PHRASE TEXT−SENTENCE D E B CA D EC list alternative cause condition A B SN NS RHETORICAL STRUCTURE DOCUMENT STRUCTURE Figure 4 Document structure is not always isomorphic with rhetorical structure.
C00-2093 W00-1426
As a contrast, it is interesting to consider the investigation into layout by Bateman et al.(2001). Their approach could not be more different from ours.
J01-3004
Such an architecture could be thought of as a refinement of the standard pipeline (Reiter 1994), with the document-planning phase divided into two parts (rhetorical planning and document structuring).
W94-0319
grouping information into clauses and sentences” (Reiter 1994, page 164), but formatting (specified, for example, by L a T E X markup) occurs only in the final formatting stage.
W94-0319
(Bateman et al.2001, page 430) However, Bateman and his colleagues do not provide a detailed account of the formation rules for layout structure, or of the constraints on the mapping between the RST tree and the layout structure.
J01-3004
As we will try to show, texts (unless they are fairly simple) cannot be produced to a satisfactory standard unless document structure is specified earlier in the process than suggested in previous works (e.g., Reiter 1994; Reiter and Dale 2000), so that interactions with meaning and wording are taken into account.
W94-0319
4. Formal Theory of Document Structure We will describe here the formal theory of document structure that we have developed as part of the ICONOCLAST system (Power 2000; Bouayad-Agha, Power, and Scott 2000; Bouayad-Agha 2000; Bouayad-Agha, Scott, and Power 2001), which generates multiple versions of the same message in different styles (i.e., with different wording and layout).
C00-2093 W00-1426
A number of other researchers have identified cases in which “orthodox” RST analysis of a text is problematic (e.g., Moore and Pollack 1992; Moser and Moore 1996; Knott et al.2001). For example, Knott et al.(2001) report on texts from a corpus of museum labels that violate the RST principle of continuous constituency (i.e., adjacent units must be linked by a relation) but are nonetheless coherent.
J92-4007 J96-3006
In the RAGS “reference architecture” for NLG (Mellish et al.2000; Cahill et al.2001), document structure is distinguished from rhetorical structure as a data type, with no commitment as to when these two data structures are created during the generation process.
A00-1017 P01-1015
In all but a few recent cases (the ICONOCLAST system (Power 2000; Bouayad-Agha, Power, and Scott 2000; Bouayad-Agha, Scott, and Power 2001; Bouayad-Agha 2001) and the DArt bio system (Bateman et al.2001)), this is achieved by mapping directly from the underlying discourse structure (Arens and ∗ Information Technology Research Institute, University of Brighton, Lewes Road, Brighton BN2 4GJ, UK.
C00-2093 J01-3004 W00-1426
example, systems aimed at generating technical abstracts or captions for graphics would probably need to specify a “one paragraph only” limit quite early on in the process; in such cases, document structuring would start before any rhetorical or syntactic decisions were made (e.g., the RAGS reimplementation of the Caption Generation System [Mellish et al.2000]). Alternatively, systems that need to generate texts with rich layout might prefer to interleave document structuring with rhetorical structuring (e.g., Cahill et al.2001). 9 Note that a vertical list can also be coordinated with units larger than text-phrases, such as text-sentences or paragraphs.
A00-1017 P01-1015
1991; Bouayad-Agha, Power, and Scott 2000).
C00-2093 W00-1426
Email: Nadjet.Bouayad@ tecm.upf.es. 212 Computational Linguistics Volume 29, Number 2 Hovy 1990; DiMarco et al.1995; Paris et al.1995; Power and Cavallotto 1996; Lavoie and Rambow 1997; Mittal et al.1998). In other cases, the text is mapped onto predetermined genre-specific layout patterns—for example, for verbalizing mathematical proofs (Huang and Fiedler 1997) or producing letters for customers (Coch 1996).
A97-1039 J98-3004 W96-0507
However, the ICONOCLAST method would work equally well if a partial assignment of document structure was part of its input: This would be treated merely as a more specific set of constraints on possible solutions, which is precisely the arrangement that is used in the RAGS reimplementation of the Caption Generation System (Mellish et al.2000). 7.2 Document Structure versus Rhetorical Structure In the terminology of HTML and other mark-up languages, tags like section and description list are sometimes called logical, suggesting that they are rhetorical rather than linguistic categories.
A00-1017
We have also reported elsewhere other similar examples of nonisomorphic rhetorical and document structures (Bouayad-Agha, Power, and Scott 2000).
C00-2093 W00-1426
As an illustration let us briefly consider the well-known consensus architecture for NLG systems proposed by Reiter (1994).
W94-0319
1 Indeed, it appears to be the case that the more graphical the presentation is, the greater the difference in wording is likely to be over the unmarked case of plain text (Bouayad-Agha, Scott, and Power 2000).
C00-2093 W00-1426
For further discussion see Bouayad-Agha, Power, and Scott (2000).
C00-2093 W00-1426
First, a distinction is made between “layout structure” and “physical layout” (Bateman et al.2001, section 3.1); although the discussion concerns boxes in a grid rather than more conventional linguistic units like section and paragraph, this distinction reflects the need for an abstract level of representation that can be related more easily to the rhetorical structure of the message.
J01-3004
The technique has been explained fully elsewhere (Power 2000), so we will confine ourselves here to a sketch of the main points.
C00-2093
