const editCategoryBtns = document.querySelectorAll('#EditCategoryBtn');

if (editCategoryBtns) {
    editCategoryBtns.forEach(btn => {
        btn.addEventListener('click', () => {
            const categoryId = btn.getAttribute('data-id');
            const categoryName = btn.getAttribute('data-name');

            console.log(categoryId, categoryName)

            document.querySelector('#AddCategoryForm #AddCategory_Id').value = categoryId;
            document.querySelector('#AddCategoryForm #AddCategory_Name').value = categoryName;

        });
    });
};

const deleteCategoryBtns = document.querySelectorAll('#DeleteCategoryBtn');

if (deleteCategoryBtns) {
    deleteCategoryBtns.forEach(btn => {
        btn.addEventListener("click", () => {
            const categoryId = btn.getAttribute('data-id');

            document.querySelector('#DeleteCategoryForm #DeleteCategoryId').value = categoryId;
        })
    });
}