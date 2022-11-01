Assignment7
 - a windows form application, for cell biologists to organize cell lines in lab

Background
The author used to work in a stem cell research lab/facility supporting extraordinary 
scientists with their lab operations daily. Stem cells are not only self-renewal (proliferative) but also 
could differentiate to other cell types with more specialized biological functions. With huge research 
and clinical potentials, they are often associated with high impact research ideas for regenerative 
medicine. With trend of large scale experiment nowadays, some scientists may have bittersweet 
feelings regarding overwhelming amount of research and clinical materials, such as stem cells in 
concern here. They proliferate, seems “grow infinitely” and “create other cells”. Furthermore, stem 
cell labs in medical science tend to have quite large numbers of individual donors. Usually each is either
a healthy donor or patient. Any misidentifying of human donors, or cross-contamination of donor’s cells 
or mislabeling of cell types may lead to disastrous consequences for both research and potentially 
clinics. Careful research and clinical materials care seems necessary in place. A chart will be shown 
below in order to illustrate why such information is necessary to keep and how situations exponentially 
go complex, and not completely impossible, out of control.

Objectives
Even for a single donor (an already much simplified scenario), she or he could potentially donate 
different starting materials from which generates many other different types of cell lines for end use. 
Keeping these amount of information neat-and-tidy maybe in need of assistance of a computer 
program and IT solutions. When worked in the previous stem cell lab/facility, scientists there (at 
that time) are using excel sitting in a Cloud server. Everyone is accessing, opening and editing same files 
at the same time. Unsurprisingly due to technique limitations (perhaps other reasons too), more and 
more cell biologists slowly get habit of omitting, poorly labeling or ill documenting information of their 
materials. To some extent, it goes unethical and becomes not a good practice in medical field. 
The program developed for this assignment will hopefully benefit other cell biologists. The basic idea is
based on keeping cells information batch by batch, which is a common principle in GMP3
assuming guaranteed consistency and reproducibility within the same batch.

Project Scope - What will not be covered?
- Batch and Cell Line ‘De-registration’ function will not be included in this project though it is 
definitely should be considered in real life examples. [Assumption:] all batches will be registered 
and cannot be deleted. Deletion of batches (discarding cells) needs to be handled separately 
outside this App.
- The user input information (all registrations) will be gone when App closes as the data are not 
written in disk. A text file might be used but writing all these types of data in a completely 
flattened file structure is perhaps not the best solution. A JSON or xml might be more useful, 
but due to time limit, file I/O will not be covered.
- To be a useful App for real life scenarios, it may easily grow as a big IT project as there are quite 
many information to keep and to organize. GUI design here is ok but not optimal. The pro is 
that it contains all information appeared with a con of squeezing all in the main Form. The 
usability of this design suffers from a ”busy” main page with “small” font size, which does not 
suit well for some users for example people with presbyopia like one of my previous colleagues 
working in that stem cell facility. Further optimization is thus needed for a such case.
